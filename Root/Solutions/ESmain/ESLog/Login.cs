﻿/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/1/28
 * 时间: 14:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Shell;

namespace ESLog
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pvf.AddFontFile(SYS.path + "\\Root\\System\\Fonts\\comic.ttf");

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			InitPaint();
			InitColor(this, new EventArgs());
			InitFont();
			BackImgLoad();
			readUsers();
		}
		
		public bool quitForRestart = false;
		public bool quit = false;
				
		private void LoginSizeChanged(object sender, EventArgs e)
		{
			InitPaint();
			BackimgPanLoad();
			InitFont();
		}

	}
}
