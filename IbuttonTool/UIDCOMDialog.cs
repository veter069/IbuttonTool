using System;
using System.Collections.Generic;
using System.Text;

using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortUsing {

	public enum WritingResult:byte{
		Success = 0,
		Fail = 1,
	};
	
	
	/// <summary>
	/// Специально для этого проекта. Переиспользование маловероятно. А вот оборачиваемый класс может быть полезен.
	/// Ивент получения последовательности из 8 байт.
	/// Последовательность разбита на BASE64-стрингу, пихнутую в uid, 
	/// и enterExit логическую переменную, принимаемую в последнем байте.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="uid">Восемь байт UID, представленные в BASE64String</param>
	/// <param name="enterExit">False - ВХОД. True - ВЫХОД.</param>
	public delegate void UIDReceivingHandler(object sender, string uid, bool enterExit);
	class UIDCOMDialog {
		const byte CANCEL_COMMAND = 88;
		#region serving objects
		private readonly COMByteSequenceReceiverSender _port;
		#endregion

		#region parameters
		private bool _paused = false;
		#endregion

		#region events
		event UIDReceivingHandler OnUIDReceived;
		#endregion

		#region Structing
		public UIDCOMDialog(string portName, int baudRate, int uIDLength, UIDReceivingHandler receivingHandler){
			OnUIDReceived += receivingHandler;
			_port = new COMByteSequenceReceiverSender(portName, baudRate, uIDLength, receiver_DataReceived);
		}
		#endregion

		#region Handling data reception
		private void receiver_DataReceived(object sender, byte[] bytes){
			OnUIDReceived(this, Convert.ToBase64String(bytes, 0, 8), Convert.ToBoolean(bytes[8]));
		}
		#endregion

		#region gettings
		public bool IsOpen(){
			return _port.IsOpen();
		}
		public bool IsPaused() {
			return _port.IsPaused();
		}
		#endregion

		#region Commands
		public void Close() {
			_port.Close();
		}

		public void Pause() {
			_port.Pause();
		}
		public void Resume() {
			_port.Resume();
		}
		public  void SendCancel() {
			_port.Send(new[] { CANCEL_COMMAND });
		}
		public void SendUID(byte[] uid)
		{
			_port.Send(uid);
		}
		#endregion
	}

	/// <summary>
	///	Ивент получения байтовой последовательности на COM-порт.
	/// Полученная информация представляется в BASE64String. Потому что мне так захотелось.
	/// На самом деле, просто так было проще сразу пихать результат в базу данных.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="bytes"></param>
	public delegate void ByteSequenceReceivingHandler(object sender, byte[] bytes);
	class COMByteSequenceReceiverSender {
		#region serving objects
		private readonly SerialPort _port;
		#endregion

		#region parameters
		private readonly int _seqLength;
		private int _accumulatedBytesCount= 0;
		private readonly byte[] _accumulatedBytes;
		private bool _paused = false;
		#endregion

		#region events
		event ByteSequenceReceivingHandler OnBytesReceived;
		#endregion

		#region Structing
		public COMByteSequenceReceiverSender(string portName, int baudRate, int seqLength, ByteSequenceReceivingHandler receivingHandler)
		{
			_port = new SerialPort(portName, baudRate);
			_port.Parity = Parity.None;
			_port.StopBits = StopBits.One;
			_port.DataBits = 8;
			_port.Handshake = Handshake.None;

			_seqLength = seqLength;
			_accumulatedBytes = new byte[_seqLength];

			OnBytesReceived += receivingHandler;

			try {
				_port.Open();
			}
			catch(Exception) {
				MessageBox.Show(null, "Не удалось получить доступ к COM-порту.", "Ошибка");
				throw;
			}

			_port.DataReceived += port_DataReceived;
		}
		#endregion

		#region Handling data reception
		private void AccumulateUID(byte[] bytes) {
			foreach(byte b in bytes) {
				_accumulatedBytes[_accumulatedBytesCount] = b;
				_accumulatedBytesCount++;
				if(_accumulatedBytesCount==_seqLength) {
					_accumulatedBytesCount = 0;
					OnBytesReceived(this, _accumulatedBytes);
				}
			}
		}

		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e){
 			byte[] bytes = new byte[_port.BytesToRead];
			_port.Read(bytes, 0, _port.BytesToRead);

			if(!_paused)
				AccumulateUID(bytes);
		}
		#endregion

		#region gettings
		public bool IsOpen() {
			if(_port!=null && _port.IsOpen)
				return true;
			return false;
		}
		public bool IsPaused() {
			return _paused;
		}
		#endregion

		#region Commands
		public void Close() {
			if (_port.IsOpen && CheckPortExistance(_port.PortName)){
				_port.Close();
				//_port.Dispose();
			}
		}

		public void Pause() {
			_paused = true;
		}
		public void Resume(){
			_accumulatedBytesCount = 0;
			_port.DiscardInBuffer();
			_paused = false;
		}
		public void Send(byte[] seq) {
			_port.Write(seq, 0, seq.Length);
		}
		#endregion

		#region Helping functions
		private bool CheckPortExistance(string portName) {
			foreach(string port in SerialPort.GetPortNames()) {
				if(port == portName) return true;
			}
			return false;
		}
		#endregion
	}

}
