/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/3
 * 时间: 10:34
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESLoad
{
	/// <summary>
	/// Description of Load_InitPaint.
	/// </summary>
	partial class Load
	{
		/// <summary>
		/// Choose theme.
		/// </summary>
		private void InitPaint(object sender, EventArgs e)
		{
			Size size = this.Size;
			
			if (size.Width >= 800 && size.Height >= 600) {
				InitPaintL();
			}
		}
		
		#region Theme
		
		/// <summary>
		/// Large monitor
		/// </summary>
		private void InitPaintL()
		{
			int PixX = Width / 10;
			int PixY = Height / 8;
			
			pictureBox1.Size = new Size(PixX * 6, PixY * 3);
			pictureBox1.Location = new Point(PixX * 2, PixY * 1);
			
			label1.Size = new Size(PixX * 3, PixY * 1);
			label1.Location = new Point(PixX * 1, PixY * 7);
			
			pictureBox2.Size = new Size(PixX * 1 / 2, PixY * 1 / 2);
			pictureBox2.Location = new Point(PixX * 1, PixY * 6);
		}
		#endregion
		
	}
}
