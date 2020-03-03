namespace ProjektiOOP.Components
{
	partial class MenuRow
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
			this.txtEmri = new System.Windows.Forms.TextBox();
			this.txtKategoria = new System.Windows.Forms.TextBox();
			this.txtCmimi = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtEmri
			// 
			this.txtEmri.Location = new System.Drawing.Point(3, 3);
			this.txtEmri.Multiline = true;
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.ReadOnly = true;
			this.txtEmri.Size = new System.Drawing.Size(210, 27);
			this.txtEmri.TabIndex = 0;
			// 
			// txtKategoria
			// 
			this.txtKategoria.Location = new System.Drawing.Point(206, 3);
			this.txtKategoria.Multiline = true;
			this.txtKategoria.Name = "txtKategoria";
			this.txtKategoria.ReadOnly = true;
			this.txtKategoria.Size = new System.Drawing.Size(90, 27);
			this.txtKategoria.TabIndex = 2;
			// 
			// txtCmimi
			// 
			this.txtCmimi.Location = new System.Drawing.Point(291, 3);
			this.txtCmimi.Multiline = true;
			this.txtCmimi.Name = "txtCmimi";
			this.txtCmimi.ReadOnly = true;
			this.txtCmimi.Size = new System.Drawing.Size(87, 27);
			this.txtCmimi.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Snow;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(384, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "Fshij";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MenuRow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCmimi);
			this.Controls.Add(this.txtKategoria);
			this.Controls.Add(this.txtEmri);
			this.Name = "MenuRow";
			this.Size = new System.Drawing.Size(471, 32);
			this.Load += new System.EventHandler(this.MenuRow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEmri;
		private System.Windows.Forms.TextBox txtKategoria;
		private System.Windows.Forms.TextBox txtCmimi;
		private System.Windows.Forms.Button button1;
	}
}
