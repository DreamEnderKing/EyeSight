/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/2/17
 * 时间: 12:49
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace ESLog
{
	partial class PicturePicker
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.Img = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
			this.SuspendLayout();
			// 
			// Img
			// 
			this.Img.Location = new System.Drawing.Point(0, 0);
			this.Img.Name = "Img";
			this.Img.Size = new System.Drawing.Size(119, 89);
			this.Img.TabIndex = 0;
			this.Img.TabStop = false;
			// 
			// PicturePicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Img);
			this.Name = "PicturePicker";
			((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox Img;
	}
}
