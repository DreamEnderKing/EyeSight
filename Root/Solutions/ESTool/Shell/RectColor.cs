/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/6
 * 时间: 10:14
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
	partial class Img
	{
		/// <summary>
		/// Get the average color in the region of rectangle
		/// </summary>
		/// <param name="bitmap">The picture you wang to get color from</param>
		/// <param name="rect">The region that will be calculated</param>
		/// <returns></returns>
		public Color getAverage(Bitmap bitmap, Rectangle r)
		{
			imgdata d = getData(bitmap, r);
			int bs = 0, gs = 0, rs = 0;
			for (int i = 0; i < d.index; i++) {
				bs += d.b[i];
				gs += d.g[i];
				rs += d.r[i];
			}
			return Color.FromArgb(rs / d.index, gs / d.index, rs / d.index);
		}
	}
}
