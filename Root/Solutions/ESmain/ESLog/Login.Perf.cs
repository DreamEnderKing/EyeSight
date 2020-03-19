/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/6
 * 时间: 16:27
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shell;

namespace ESLog
{
	partial class Login
	{
		#region BackgroundImageChange
		private async void BackImgLoad()
		{
			this.BackgroundImage = new Bitmap(new Temp().LoadFile(SYS.path + @"\User\Common\Data\login.dat"));
			InitColor(this, new EventArgs());
		}
		
		private void BackimgPanLoad()
		{
			foreach (Control control in BackimgPan.Controls) {
				if (control.GetType()==typeof(PicturePicker))
				{
					control.Visible = false;
					//((Shell.FormControlTagData)control.Tag).needDispose = true;
				}
			}
			DirectoryInfo d = new DirectoryInfo(SYS.path + @"\User\Common\LoginImg");
			Int32 n = 0, x = 0, y = 0;
			foreach (var file in d.EnumerateFiles()) {
				PicturePicker p = new PicturePicker();
				x = n % 4;
				y = n / 4;
				Shell.FormControlTagData dat = new FormControlTagData();
				p.Tag = dat;
				BackimgPan.Controls.Add(p);
				p.Size = new Size((BackimgPan.Width / 4 - 6) - 6, BackimgPan.Height / 3 - 8);
				p.Location = new Point((BackimgPan.Width / 4 - 6) * x + 3, BackimgPan.Height / 3 * y + 10 + label1.Height);
				p.Image = new Bitmap(new Temp().LoadFile(file.FullName));
				n++;
				//Timer1.AddControl(p);
			}
		}
		#endregion
		
		#region AccountLogin
		private HashSet<String> Users;
		
		private void readUsers()
		{
			
		}
		#endregion
	}
}
