﻿/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/1/28
 * 时间: 12:02
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Shell;

namespace ESLoad
{
	/// <summary>
	/// Description of Load.
	/// </summary>
	public partial class Load : Form
	{
		public Load()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			start = DateTime.Now;
			
		}
		
		
		/// <summary>
		/// Counting the time.
		/// </summary>
		DateTime start;
		int span = 7;
		void Timer1Tick(object sender, EventArgs e)
		{
			if((DateTime.Now - start).Seconds >= span)
				this.Close();
			
		}
		
		void LoadLoad(object sender, EventArgs e)
		{
			new Temp().ClearTemp();
		}
	}
}
