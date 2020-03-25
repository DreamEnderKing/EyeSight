/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/4
 * 时间: 10:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using Shell;

namespace ESLog
{
	partial class Login
	{
		private void InitPaint()
		{
			if(Width >= 500 && Height >= 600)
			{
				int DpiX = Width / 10;
				int DpiY = Height / 8;
				
				UserIcon.Size = new System.Drawing.Size(DpiX * 2, DpiX * 2);
				UserIcon.Location = new System.Drawing.Point(DpiX * 4, DpiY * 1 / 2);
				
				BackBtn.Size = new System.Drawing.Size(DpiX / 2, DpiY / 2);
				BackBtn.Location = new System.Drawing.Point(DpiX * 3, DpiY * 7 / 2);
				
				ForeBtn.Size = new System.Drawing.Size(DpiX / 2, DpiY / 2);
				ForeBtn.Location = new System.Drawing.Point(DpiX * 13 / 2, DpiY * 7 / 2);
				
				SubmitBtn.Size = new System.Drawing.Size(DpiX, DpiY / 2);
				SubmitBtn.Location = new System.Drawing.Point(DpiX * 9 / 2, DpiY * 21 / 4);
				
				KeyField.Location = new System.Drawing.Point(DpiX * 7 / 2, DpiY * 9 / 2);
				KeyField.Size = new System.Drawing.Size(DpiX * 3, DpiY / 2);
				
				WaitImg.Location = new System.Drawing.Point(DpiX * 13 / 4, DpiY * 7 / 2);
				WaitImg.Size = new System.Drawing.Size(DpiX / 2, DpiY / 2);
				
				WelText.Size = new System.Drawing.Size(DpiX * 5, DpiY / 2);
				WelText.Location = new System.Drawing.Point(DpiX * 17 / 4, DpiY * 7 / 2);
				
				NameText.Size = new System.Drawing.Size(DpiX * 2, DpiY / 2);
				NameText.Location = new System.Drawing.Point(DpiX * 4, DpiY * 7 / 2);
				
				BackimgPan.Size = new System.Drawing.Size(DpiX * 3, DpiY * 2);
				BackimgPan.Location = new System.Drawing.Point(0, 0);
				
				label1.Size = new Size(BackimgPan.Width - 2, label1.Font.Height + 5);
				label1.Location = new Point(0, 0);
				
				
			}
		}
		
		/// <summary>
		/// Init the color so that the text will show clearly.
		/// </summary>
		private void InitColor(object sender, EventArgs e)
		{
			Img i = new Img();
			NameText.ForeColor = i.simplifyColor(i.reverseColor(i.getAverage((System.Drawing.Bitmap)this.BackgroundImage, new System.Drawing.Rectangle(NameText.Location, NameText.Size))));
			WelText.ForeColor = i.simplifyColor(i.reverseColor(i.getAverage((System.Drawing.Bitmap)this.BackgroundImage, new System.Drawing.Rectangle(WelText.Location, WelText.Size))));
		}
		
		/// <summary>
		/// Init the font.
		/// </summary>
		private System.Drawing.Text.PrivateFontCollection pvf = new System.Drawing.Text.PrivateFontCollection();
		private void InitFont()
		{
			KeyField.Font = new System.Drawing.Font("宋体", KeyField.Height - 6, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
			NameText.Font = new Font("宋体", NameText.Height - 6, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(8)));
			label1.Font = new Font(pvf.Families[0], label1.Width / (label1.Text.Length + 2), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WelText.Font = new System.Drawing.Font("宋体", WelText.Height - 2, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

		}
		
		
	}
}
