namespace IbuttonTool
{
	partial class UIDReadingForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.b_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(78, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ожидаю предоставления UID...";
			// 
			// b_cancel
			// 
			this.b_cancel.Location = new System.Drawing.Point(122, 63);
			this.b_cancel.Name = "b_cancel";
			this.b_cancel.Size = new System.Drawing.Size(75, 23);
			this.b_cancel.TabIndex = 1;
			this.b_cancel.Text = "Отмена";
			this.b_cancel.UseVisualStyleBackColor = true;
			this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
			// 
			// UIDReadingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 98);
			this.ControlBox = false;
			this.Controls.Add(this.b_cancel);
			this.Controls.Add(this.label1);
			this.Name = "UIDReadingForm";
			this.Text = "Чтение UID через COM-port";
			this.Load += new System.EventHandler(this.UIDReadingForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button b_cancel;
	}
}