namespace ProjektiOOP.Components
{
	partial class OrderDetailContainer
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Produkti :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(212, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sasia";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(263, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cmimi";
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtName.Enabled = false;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txtName.Location = new System.Drawing.Point(4, 27);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(201, 28);
			this.txtName.TabIndex = 3;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtQuantity
			// 
			this.txtQuantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtQuantity.Enabled = false;
			this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantity.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txtQuantity.Location = new System.Drawing.Point(202, 27);
			this.txtQuantity.Multiline = true;
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(58, 28);
			this.txtQuantity.TabIndex = 4;
			this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
			// 
			// txtPrice
			// 
			this.txtPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtPrice.Enabled = false;
			this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txtPrice.Location = new System.Drawing.Point(256, 27);
			this.txtPrice.Multiline = true;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(58, 28);
			this.txtPrice.TabIndex = 5;
			this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
			this.btnDelete.Location = new System.Drawing.Point(367, 27);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(60, 28);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Fshij";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtTotalPrice.Enabled = false;
			this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txtTotalPrice.Location = new System.Drawing.Point(311, 27);
			this.txtTotalPrice.Multiline = true;
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(50, 28);
			this.txtTotalPrice.TabIndex = 7;
			this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(320, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "Total";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// OrderDetailContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "OrderDetailContainer";
			this.Size = new System.Drawing.Size(430, 59);
			this.Load += new System.EventHandler(this.OrderDetailContainer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label label4;
	}
}
