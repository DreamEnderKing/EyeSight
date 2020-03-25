/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/25
 * 时间: 10:29
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Shell
{
	/// <summary>
	/// Description of DealImage.
	/// </summary>
	public partial class Img
	{
		public Bitmap CutCircle(Image img)
		{
			Bitmap image = new Bitmap(img);
			Bitmap b = new Bitmap(image.Width, image.Height);
			using (Graphics g = Graphics.FromImage(b)) {
				Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
				TextureBrush brush = new TextureBrush(image, rect);
				g.FillEllipse(brush, rect);
				g.Flush();
			}
			image.Dispose();
			return b;
		}
	}
}
