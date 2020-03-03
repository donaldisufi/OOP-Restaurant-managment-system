namespace ProjektiOOP
{
	partial class UserStack
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
			this.ctnReservo = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dtData = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPersons = new System.Windows.Forms.TextBox();
			this.cmbTable = new System.Windows.Forms.ComboBox();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctnReservo
			// 
			this.ctnReservo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.ctnReservo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.ctnReservo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.ctnReservo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.ctnReservo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.ctnReservo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ctnReservo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctnReservo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.ctnReservo.Location = new System.Drawing.Point(354, 407);
			this.ctnReservo.Name = "ctnReservo";
			this.ctnReservo.Size = new System.Drawing.Size(207, 45);
			this.ctnReservo.TabIndex = 21;
			this.ctnReservo.Text = "Rezervo";
			this.ctnReservo.UseVisualStyleBackColor = false;
			this.ctnReservo.Click += new System.EventHandler(this.ctnReservo_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(351, 290);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 20;
			this.label3.Text = "Zgjedh Daten";
			// 
			// dtData
			// 
			this.dtData.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtData.Location = new System.Drawing.Point(354, 321);
			this.dtData.Name = "dtData";
			this.dtData.Size = new System.Drawing.Size(207, 20);
			this.dtData.TabIndex = 19;
			this.dtData.ValueChanged += new System.EventHandler(this.dtData_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(106, 390);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 17);
			this.label2.TabIndex = 18;
			this.label2.Text = "Cakto numrin e personave";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(107, 290);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 17);
			this.label1.TabIndex = 17;
			this.label1.Text = "Zgjedh Tavolinen";
			// 
			// txtPersons
			// 
			this.txtPersons.Location = new System.Drawing.Point(109, 423);
			this.txtPersons.Multiline = true;
			this.txtPersons.Name = "txtPersons";
			this.txtPersons.Size = new System.Drawing.Size(170, 30);
			this.txtPersons.TabIndex = 16;
			// 
			// cmbTable
			// 
			this.cmbTable.FormattingEnabled = true;
			this.cmbTable.Location = new System.Drawing.Point(110, 322);
			this.cmbTable.Name = "cmbTable";
			this.cmbTable.Size = new System.Drawing.Size(170, 21);
			this.cmbTable.TabIndex = 15;
			this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTAble_SelectedIndexChanged);
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.lblWelcome.Location = new System.Drawing.Point(254, 42);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(0, 39);
			this.lblWelcome.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label4.Location = new System.Drawing.Point(218, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(227, 26);
			this.label4.TabIndex = 24;
			this.label4.Text = "Make an reservation";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(661, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 45);
			this.button1.TabIndex = 25;
			this.button1.Text = "Log out";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// UserStack
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 512);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.ctnReservo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtData);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPersons);
			this.Controls.Add(this.cmbTable);
			this.Name = "UserStack";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserStack";
			this.Load += new System.EventHandler(this.UserStack_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ctnReservo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtData;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPersons;
		private System.Windows.Forms.ComboBox cmbTable;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
	}
}