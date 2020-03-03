/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/1/28
 * 时间: 14:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace ESLog
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.picturePicker1 = new ESLog.PicturePicker();
			this.SuspendLayout();
			// 
			// picturePicker1
			// 
			this.picturePicker1.BackColor = System.Drawing.SystemColors.Control;
			this.picturePicker1.Image = ((System.Drawing.Image)(resources.GetObject("picturePicker1.Image")));
			this.picturePicker1.Location = new System.Drawing.Point(16, 63);
			this.picturePicker1.Name = "picturePicker1";
			this.picturePicker1.Selected = true;
			this.picturePicker1.Size = new System.Drawing.Size(359, 242);
			this.picturePicker1.TabIndex = 0;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 354);
			this.Controls.Add(this.picturePicker1);
			this.Name = "Login";
			this.Text = "Login";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.ResumeLayout(false);
		}
		private ESLog.PicturePicker picturePicker1;
	}
}
