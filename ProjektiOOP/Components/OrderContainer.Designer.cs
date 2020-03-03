namespace ProjektiOOP.Components
{
	partial class OrderContainer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblNumber = new System.Windows.Forms.Label();
			this.panMainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnPerfundo = new System.Windows.Forms.Button();
			this.lblTable = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPuntori = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblTitle.Location = new System.Drawing.Point(163, 15);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(108, 17);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Porosia numer :";
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblNumber.Location = new System.Drawing.Point(277, 15);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(16, 17);
			this.lblNumber.TabIndex = 2;
			this.lblNumber.Text = "0";
			// 
			// panMainPanel
			// 
			this.panMainPanel.AllowDrop = true;
			this.panMainPanel.AutoScroll = true;
			this.panMainPanel.Location = new System.Drawing.Point(3, 85);
			this.panMainPanel.Name = "panMainPanel";
			this.panMainPanel.Size = new System.Drawing.Size(461, 248);
			this.panMainPanel.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.button1.Location = new System.Drawing.Point(392, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Refresh";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnPerfundo
			// 
			this.btnPerfundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPerfundo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnPerfundo.Location = new System.Drawing.Point(127, 339);
			this.btnPerfundo.Name = "btnPerfundo";
			this.btnPerfundo.Size = new System.Drawing.Size(189, 36);
			this.btnPerfundo.TabIndex = 12;
			this.btnPerfundo.Text = "Perfundo Porosine";
			this.btnPerfundo.UseVisualStyleBackColor = true;
			this.btnPerfundo.Click += new System.EventHandler(this.btnPerfundo_Click);
			// 
			// lblTable
			// 
			this.lblTable.AutoSize = true;
			this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTable.ForeColor = System.Drawing.Color.DarkRed;
			this.lblTable.Location = new System.Drawing.Point(277, 52);
			this.lblTable.Name = "lblTable";
			this.lblTable.Size = new System.Drawing.Size(16, 17);
			this.lblTable.TabIndex = 14;
			this.lblTable.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkRed;
			this.label2.Location = new System.Drawing.Point(163, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "Tavolina Numer";
			// 
			// lblPuntori
			// 
			this.lblPuntori.AutoSize = true;
			this.lblPuntori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPuntori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblPuntori.Location = new System.Drawing.Point(63, 36);
			this.lblPuntori.Name = "lblPuntori";
			this.lblPuntori.Size = new System.Drawing.Size(16, 17);
			this.lblPuntori.TabIndex = 16;
			this.lblPuntori.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(44, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "Puntori :";
			// 
			// OrderContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.lblPuntori);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblTable);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnPerfundo);
			this.Controls.Add(this.panMainPanel);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.lblTitle);
			this.Name = "OrderContainer";
			this.Size = new System.Drawing.Size(467, 384);
			this.Load += new System.EventHandler(this.OrderContainer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.FlowLayoutPanel panMainPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnPerfundo;
		private System.Windows.Forms.Label lblTable;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblPuntori;
		private System.Windows.Forms.Label label3;
	}
}
