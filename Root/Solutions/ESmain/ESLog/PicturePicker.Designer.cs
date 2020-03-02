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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicturePicker));
			this.Img = new System.Windows.Forms.PictureBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
			this.SuspendLayout();
			// 
			// Img
			// 
			this.Img.BackColor = System.Drawing.Color.Transparent;
			this.Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Img.Image = ((System.Drawing.Image)(resources.GetObject("Img.Image")));
			this.Img.Location = new System.Drawing.Point(0, 0);
			this.Img.Name = "Img";
			this.Img.Size = this.Size;
			this.Img.TabIndex = 0;
			this.Img.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Image");
			// 
			// PicturePicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.Img);
			this.Name = "PicturePicker";
			this.Load += new System.EventHandler(this.PicturePickerLoad);
			this.SizeChanged += new System.EventHandler(this.PicturePickerSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox Img;
	}
}
