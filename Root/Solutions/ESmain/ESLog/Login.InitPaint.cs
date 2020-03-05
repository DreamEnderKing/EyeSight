/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/4
 * 时间: 10:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace ESLog
{
	partial class Login
	{
		private void InitPaint()
		{
			int DpiX = Width / 10;
			int DpiY = Height / 8;
			
			UserIcon.Size = new System.Drawing.Size(DpiX * 2, DpiX * 2);
			UserIcon.Location = new System.Drawing.Point(DpiX * 4, DpiY * 1);
			
			BackBtn.Size = new System.Drawing.Size(DpiX / 2, DpiY / 2);
			BackBtn.Location = new System.Drawing.Point(DpiX * 3, DpiY * 7 / 2);
			
			ForeBtn.Size = new System.Drawing.Size(DpiX / 2, DpiY / 2);
			ForeBtn.Location = new System.Drawing.Point(DpiX * 13 / 2, DpiY * 7 / 2);
			
			SubmitBtn.Size = new System.Drawing.Size(DpiX / 2, DpiY / 2);
			SubmitBtn.Location = new System.Drawing.Point(DpiX * 13 / 2, DpiY * 9 / 2);
			
			KeyField.Size = new System.Drawing.Size(DpiX * 2, DpiY / 2);
			KeyField.Location = new System.Drawing.Point(DpiX * 4, DpiY * 9 / 2);
			
			WaitImg.Location = new System.Drawing.Point(DpiX * 15 / 4, DpiY * 9 / 2);
			WaitImg.Size = new System.Drawing.Size(DpiX / 2, DpiY / 2);
			
			WelText.Size = new System.Drawing.Size(DpiX * 2, DpiY / 2);
			WelText.Location = new System.Drawing.Point(DpiX * 19 / 4, DpiY * 9 / 2);
			
			NameText.Size = new System.Drawing.Size(DpiX * 2, DpiY / 2);
			NameText.Location = new System.Drawing.Point(DpiX * 4, DpiY * 7 / 2);
			
			BackimgPan.Size = new System.Drawing.Size(DpiX * 3, DpiY * 2);
			BackimgPan.Location = new System.Drawing.Point(0, 0);
			
		}
		
		/// <summary>
		/// Init the color so that the text will show clearly.
		/// </summary>
		private void InitColor()
		{
			
		}
		
		
	}
}
