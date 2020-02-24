/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/2/17
 * 时间: 12:49
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ESLog
{
	/// <summary>
	/// Description of PicturePicker.
	/// </summary>
	public partial class PicturePicker : UserControl
	{
		public PicturePicker()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Img.Width = Width;
			Img.Height = Height;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private bool _Selected;
		
		public bool Seleced
		{
			get {return _Selected; }
			set {_Selected = true; }
		}
		
		public Image Image
		{
			get {return Img.BackgroundImage;}
			set {Img.BackgroundImage = value;}
		}
		
		private void paintSelect()
		{
			if (_Selected) {
				
			}
		}
	}
}
