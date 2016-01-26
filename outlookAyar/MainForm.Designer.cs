/*
 * Created by SharpDevelop.
 * User: Ramazan TÜFEKÇİ
 * Web Site:www.ramazantufekci.com
 * Date: 1/26/2016
 * Time: 8:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace outlookAyar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(58, 83);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Ayarları Benim için Yap";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 209);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kodlayan : Ramazan TÜFEKÇİ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "outlookAyar";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}
