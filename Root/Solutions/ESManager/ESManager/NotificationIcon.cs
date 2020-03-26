/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2020/1/27
 * Time: 18:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ESManager
{
	public sealed class NotificationIcon
	{
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));

		
		#region Initialize icon and menu
		public NotificationIcon()
		{
			notifyIcon = new NotifyIcon();
			notificationMenu = new ContextMenu(InitializeMenu());
			
			notifyIcon.Icon = (Icon)resources.GetObject("logo");
			notifyIcon.ContextMenu = notificationMenu;
		}
		
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("About", menuAboutClick),
				new MenuItem("Start", menuStartClick),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			bool isFirstInstance;
			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, "ESManager", out isFirstInstance)) {
				if (isFirstInstance) {
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				} else {
					// The application is already running
					// TODO: Display message box or change focus to existing application instance
				}
			} // releases the Mutex
		}
		#endregion
		
		#region Event Handlers
		private void menuAboutClick(object sender, EventArgs e)
		{
			MessageBox.Show("About This Application");
		}
		
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void menuStartClick(object sender, EventArgs e)
		{
			Start();
		}
		#endregion
		
		#region Start thr program
		private Process ES = new Process();
		
		private void Start()
		{
			//Disable Restart
			this.notifyIcon.Icon = (Icon)resources.GetObject("logoDisabled");
			notifyIcon.MouseClick += IconClick;
			notifyIcon.ContextMenu = null;
			
			//run the application
			ES.StartInfo.FileName = Application.StartupPath + "\\ESMain.exe";
			ES.Start();
			ES.WaitForExit();
			if(ES.ExitCode == 0)
			{
				Application.ExitThread();
				notifyIcon.MouseClick -= IconClick;
				Application.Exit();
			}
			else if(ES.ExitCode == 400)
			{
				Start();
			}

		}
		
		private void IconClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show("System is running!");
		}
		#endregion
	}
}
