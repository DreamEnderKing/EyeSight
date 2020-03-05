/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/1/28
 * 时间: 11:53
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Windows.Forms;
using ESLoad;
using ESDesktop;
using ESLog;

namespace ESMain
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			runApplication app = new runApplication();
			while(!quit)
			{
				Application.DoEvents();
			}
		}
		
		public static bool quit = false;
		
	}
	
	class runApplication
	{
		public runApplication()
		{
			run();
		}
		
		private void run()
		{
			Load l = new Load();
			l.Show();
			l.Closed += load_Exit;
		}
		
		private void load_Exit(object sender, EventArgs e)
		{
			Login o = new Login();
			o.Show();
			o.Closed += login_Exit;
		}
		
		private void login_Exit(object sender, EventArgs e)
		{
			Login form = (Login)sender;
			if(!form.quitForRestart)
			{
				Desktop d = new Desktop();
				d.Show();
				d.Closed += desktop_Exit;
			}
			else
			{
				Shutdown s = new Shutdown();
				s.Show();
				s.Closed += shutdown_Exit;
				s.quitForRestart = true;
			}
		}
		
		private void desktop_Exit(object sender, EventArgs e)
		{
			Desktop form = (Desktop)sender;
			Shutdown s = new Shutdown();
			s.Show();
			s.Closed += shutdown_Exit;
			s.quitForRestart = form.quitForRestart;
		}
		
		private void shutdown_Exit(object sender, EventArgs e)
		{
			System.Environment.Exit(0);
		}


	}
}
