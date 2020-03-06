/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/6
 * 时间: 10:28
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
	/// Description of SingleColor.
	/// </summary>
	partial class Img
	{
		/// <summary>
		/// Get the color reversed.
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public Color reverseColor(Color color)
		{
			return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
		}
		
		/// <summary>
		/// Make the color into simple color.
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public Color simplifyColor(Color color)
		{
			int r = (color.R >= 127)?255:0;
			int g = (color.G >= 127)?255:0;
			int b = (color.B >= 127)?255:0;
			return Color.FromArgb(r, g, b);
		}
	}
}
