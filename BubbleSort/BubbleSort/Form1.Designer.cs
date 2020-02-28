namespace BubbleSort
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lbllength = new System.Windows.Forms.Label();
			this.lblcmp = new System.Windows.Forms.Label();
			this.lblswp = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tblength = new System.Windows.Forms.TextBox();
			this.tbmax = new System.Windows.Forms.TextBox();
			this.btnrandom = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(298, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(183, 342);
			this.listBox1.TabIndex = 0;
			// 
			// lbllength
			// 
			this.lbllength.AutoSize = true;
			this.lbllength.Location = new System.Drawing.Point(12, 12);
			this.lbllength.Name = "lbllength";
			this.lbllength.Size = new System.Drawing.Size(67, 13);
			this.lbllength.TabIndex = 1;
			this.lbllength.Text = "Array Length";
			// 
			// lblcmp
			// 
			this.lblcmp.AutoSize = true;
			this.lblcmp.Location = new System.Drawing.Point(12, 35);
			this.lblcmp.Name = "lblcmp";
			this.lblcmp.Size = new System.Drawing.Size(67, 13);
			this.lblcmp.TabIndex = 2;
			this.lblcmp.Text = "Comparisons";
			// 
			// lblswp
			// 
			this.lblswp.AutoSize = true;
			this.lblswp.Location = new System.Drawing.Point(12, 59);
			this.lblswp.Name = "lblswp";
			this.lblswp.Size = new System.Drawing.Size(39, 13);
			this.lblswp.TabIndex = 3;
			this.lblswp.Text = "Swaps";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnrandom);
			this.groupBox1.Controls.Add(this.tbmax);
			this.groupBox1.Controls.Add(this.tblength);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 236);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 118);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Random Array";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Length:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numbers Maximum:";
			// 
			// tblength
			// 
			this.tblength.Location = new System.Drawing.Point(111, 22);
			this.tblength.Name = "tblength";
			this.tblength.Size = new System.Drawing.Size(163, 20);
			this.tblength.TabIndex = 2;
			// 
			// tbmax
			// 
			this.tbmax.Location = new System.Drawing.Point(111, 48);
			this.tbmax.Name = "tbmax";
			this.tbmax.Size = new System.Drawing.Size(163, 20);
			this.tbmax.TabIndex = 3;
			// 
			// btnrandom
			// 
			this.btnrandom.Location = new System.Drawing.Point(9, 84);
			this.btnrandom.Name = "btnrandom";
			this.btnrandom.Size = new System.Drawing.Size(265, 23);
			this.btnrandom.TabIndex = 4;
			this.btnrandom.Text = "Create and Sort";
			this.btnrandom.UseVisualStyleBackColor = true;
			this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 369);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblswp);
			this.Controls.Add(this.lblcmp);
			this.Controls.Add(this.lbllength);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Bubble Sort";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label lbllength;
		private System.Windows.Forms.Label lblcmp;
		private System.Windows.Forms.Label lblswp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnrandom;
		private System.Windows.Forms.TextBox tbmax;
		private System.Windows.Forms.TextBox tblength;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

