namespace IbuttonTool
{
	partial class UIDWritingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.b_cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// b_cancel
			// 
			this.b_cancel.Location = new System.Drawing.Point(131, 63);
			this.b_cancel.Name = "b_cancel";
			this.b_cancel.Size = new System.Drawing.Size(75, 23);
			this.b_cancel.TabIndex = 3;
			this.b_cancel.Text = "Отмена";
			this.b_cancel.UseVisualStyleBackColor = true;
			this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ожидаю предоставления iButton...";
			// 
			// UIDWritingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 98);
			this.ControlBox = false;
			this.Controls.Add(this.b_cancel);
			this.Controls.Add(this.label1);
			this.Name = "UIDWritingForm";
			this.Text = "Запись UID";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button b_cancel;
		private System.Windows.Forms.Label label1;
	}
}