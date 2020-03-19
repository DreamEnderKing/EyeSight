﻿/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/1/31
 * 时间: 18:30
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Tar;
using Shell;

namespace DEBUGTOOL
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		int x = 0;
		int y = 0;
		void Button1Click(object sender, EventArgs e)
		{
			Img i = new Img();
			Color c = i.getAverage((Bitmap)BackgroundImage, new Rectangle(button2.Location, button2.Size));
			button2.BackColor = c;
			button2.ForeColor = i.simplifyColor(i.reverseColor(c));
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			FileStream stream = new FileStream(Application.StartupPath + "\\abc.tar", FileMode.OpenOrCreate);
			MessageBox.Show(stream.Name);
			TarOutputStream output = new TarOutputStream(stream);
			TarHeader header = new TarHeader();
			header.Name = "123.txt";
			header.Size = 0;
			TarEntry entry = new TarEntry(header);
			entry.TarHeader.Size += 1;
			output.PutNextEntry(entry);
			output.WriteByte(Convert.ToByte('a'));
			output.Flush();
			output.Dispose();
			
		}
	}
}
