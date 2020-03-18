/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/16
 * 时间: 9:37
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Shell;

namespace UserCon
{
	/// <summary>
	/// Description of Timer_Clean.
	/// </summary>
	public partial class Timer_Clean : Timer
	{
		public Timer_Clean()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			ConList = new System.Collections.Generic.List<IntPtr>();
			this.Tick += CleanMemory;
			this.Interval = 60000;
			
		}
		
		private System.Collections.Generic.List<IntPtr> ConList;
		
		public void AddControl(Control con)
		{
			try {
				Shell.FormControlTagData dat = (Shell.FormControlTagData)con.Tag;
				ConList.Add(con.Handle);
			} catch (Exception) {
				
				throw new ArgumentException("Tag data don't match.");
			}
		}
		
		
		private void CleanMemory(object sender, EventArgs e)
		{
			foreach (var pcon in ConList) {
				Control con = Control.FromHandle(pcon);
				FormControlTagData dat = (Shell.FormControlTagData)con.Tag;
				if(dat.needDispose = true) 
				{
					con.Dispose();
					ConList.Remove(pcon);
				}
			}
		}
	}
}
