/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/2/17
 * 时间: 11:58
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
	/// Description of MyClass.
	/// </summary>
	public partial class Img
	{
		/// <summary>
		/// Get the color data in the region of rectangle
		/// </summary>
		/// <param name="bitmap">The picture you wang to get color from</param>
		/// <param name="rect">The region that will be calculated</param>
		/// <returns></returns>
		private imgdata getData(Bitmap bitmap, Rectangle rect)
		{
			BitmapData data = bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			int nbyte = data.Width * data.Height;
			imgdata d = new imgdata(nbyte);
			int index = 0;
			int offset = data.Stride - bitmap.Width * 3 + rect.Left * 3 + rect.Right * 3;
			
			unsafe
			{
				byte* ptr = (byte*)(void*)data.Scan0;
				for (int i = 0; i < data.Height; i++) {
					for (int j = 0; j < data.Width; j++) {
						d.b[index] = *ptr;
						ptr++;
						d.g[index] = *ptr;
						ptr++;
						d.r[index] = *ptr;
						ptr++;
						index++;
					}
					ptr += offset;
				}
			}
			
			bitmap.UnlockBits(data);
			return d;
		}
	}
	
	public class imgdata
	{
		public imgdata(int n)
		{
			r = new int[n];
			g = new int[n];
			b = new int[n];
			index = n;
		}
		public int[] r;
		public int[] g;
		public int[] b;
		public int index;
	}
}