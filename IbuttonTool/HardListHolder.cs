using System;
using System.Collections.Generic;

using System.IO;

namespace System.IO{
/// <summary>
/// Просто класс, инкапсулирующий работу с листом(List), члены которого хранятся на жёстком диске в текстовом файле.
/// Для создания экземпляра придётся указать путь к файлу. Если он не существует, то будет создан.
/// В процессе работы можно добавлять и удалять члены списка, брать их по индексу и находить индекс по содержимому.
/// Для сохранения результатов нужно вызвать метод Save() или Dispose() - делают одно и то же.
/// Также есть метод Reload() - забыть внесённые изменения и считать данные заново.
/// </summary>
	class HardListHolder{
		#region objects
			#region Reader
			private StreamReader reader;
			private void SpawnReader()
			{
				if (reader != null)
					KillReader();
				reader = new StreamReader(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read));
			}
			private void KillReader()
			{
				if (reader != null)
				{
					reader.BaseStream.Close();
					reader.Close();
					reader.Dispose();
					reader = null;
				}
			}
			#endregion
			#region Writer
			StreamWriter writer;
			private void SpawnWriter()
			{
				if (writer != null)
					KillWriter();
				writer = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write));
			}
			private void KillWriter()
			{
				if (writer != null)
				{
					writer.Flush();
					writer.BaseStream.Close();
					//writer.Close();
					//writer.Dispose();
					writer = null;
				}
			}
			#endregion
			private List<String> list;
		#endregion

		#region parameters
		private string filePath;
		#endregion

		#region read/write file
		/// <summary>
		/// Вычитать всё из файлища
		/// </summary>
		private void ReadTehShit()
		{
			list.Clear();
			SpawnReader();
			while (!reader.EndOfStream){
				list.Add(reader.ReadLine());
			}
			KillReader();

			if (list.Count == 0){ // Если это первый запуск
				//throw(new Exception("NottinToRead! An empty file is ready. Shall eat Your strings. ;)"));
			}
		}
		/// <summary>
		/// Вписать всё в файлище
		/// </summary>
		private void WriteTehShit()
		{
			KillReader();
			SpawnWriter();
			foreach(string str in list){
				writer.WriteLine(str);
			}
			KillWriter();
		}
		#endregion

		#region Structing
		public HardListHolder(string pathToListFile){
			list = new List<string>();
			filePath = pathToListFile;
			ReadTehShit();
		}
		public void Dispose(){
			Save();
		}
		#endregion

		#region Public commands
		public void Reload(){
			ReadTehShit();
		}
		public void Save(){
			WriteTehShit();
		}

		public void Add(string str){
			list.Add(str);
		}
		public void ReplaceAt(int index, string newStr){
			list[index] = newStr;
		}
		public void RemoveAt(int index){
			list.RemoveAt(index);
		}
		#endregion

		#region Settings
		public void SetFilePath(string pathToListFile, bool reloadList){
			filePath = pathToListFile;
			if(reloadList) ReadTehShit();
		}
		#endregion

		#region gettings
		public string[] GetArray(){
			return list.ToArray();
		}
		public int GetCount(){
			return list.Count;
		}
		public List<string> GetList(){
			return new List<string>(list.ToArray());
		}
		public int FindIndex(string str){
			return list.IndexOf(str);
		}
		#endregion
	}
}
