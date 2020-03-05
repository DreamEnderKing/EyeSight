/*
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

namespace ESLog
{
	/// <summary>
	/// Description of Shutdown.
	/// </summary>
	public partial class Shutdown : Form
	{
		public Shutdown()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public bool quitForRestart = false;

	}
}
