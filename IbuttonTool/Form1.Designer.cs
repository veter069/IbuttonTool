namespace IbuttonTool
{
	partial class Form1
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
			this.mtb_uid = new System.Windows.Forms.MaskedTextBox();
			this.b_Read = new System.Windows.Forms.Button();
			this.b_Write = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.lB_UID_List = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ms_settings = new System.Windows.Forms.ToolStripMenuItem();
			this.ms_settings_com = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mtb_uid
			// 
			this.mtb_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mtb_uid.Location = new System.Drawing.Point(12, 23);
			this.mtb_uid.Mask = "aa:aa:aa:aa:aa:aa:aa:aa";
			this.mtb_uid.Name = "mtb_uid";
			this.mtb_uid.Size = new System.Drawing.Size(388, 44);
			this.mtb_uid.TabIndex = 0;
			// 
			// b_Read
			// 
			this.b_Read.Location = new System.Drawing.Point(12, 73);
			this.b_Read.Name = "b_Read";
			this.b_Read.Size = new System.Drawing.Size(75, 23);
			this.b_Read.TabIndex = 1;
			this.b_Read.Text = "READ";
			this.b_Read.UseVisualStyleBackColor = true;
			this.b_Read.Click += new System.EventHandler(this.b_Read_Click);
			// 
			// b_Write
			// 
			this.b_Write.Location = new System.Drawing.Point(93, 73);
			this.b_Write.Name = "b_Write";
			this.b_Write.Size = new System.Drawing.Size(75, 23);
			this.b_Write.TabIndex = 2;
			this.b_Write.Text = "WRITE";
			this.b_Write.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(174, 73);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "SAVE";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// lB_UID_List
			// 
			this.lB_UID_List.FormattingEnabled = true;
			this.lB_UID_List.Location = new System.Drawing.Point(12, 102);
			this.lB_UID_List.Name = "lB_UID_List";
			this.lB_UID_List.Size = new System.Drawing.Size(388, 199);
			this.lB_UID_List.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(255, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 20);
			this.textBox1.TabIndex = 5;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_settings});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(411, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ms_settings
			// 
			this.ms_settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_settings_com});
			this.ms_settings.Name = "ms_settings";
			this.ms_settings.Size = new System.Drawing.Size(79, 20);
			this.ms_settings.Text = "Настройки";
			// 
			// ms_settings_com
			// 
			this.ms_settings_com.Name = "ms_settings_com";
			this.ms_settings_com.Size = new System.Drawing.Size(152, 22);
			this.ms_settings_com.Text = "COM порт";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 315);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lB_UID_List);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.b_Write);
			this.Controls.Add(this.b_Read);
			this.Controls.Add(this.mtb_uid);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "IbuttonTool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox mtb_uid;
		private System.Windows.Forms.Button b_Read;
		private System.Windows.Forms.Button b_Write;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListBox lB_UID_List;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ms_settings;
		private System.Windows.Forms.ToolStripMenuItem ms_settings_com;
	}
}

