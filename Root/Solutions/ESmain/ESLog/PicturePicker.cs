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
			
			mask = (Bitmap)imageList1.Images[0];
			canvas = new Bitmap(Width, Height);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private bool _Selected;
		
		public bool Selected
		{
			get {return _Selected; }
			set {_Selected = value; paintSelect();}
		}
		
		public Image Image
		{
			get {return Img.BackgroundImage;}
			set {Img.BackgroundImage = value; paintSelect();}
		}
		
		private Bitmap mask;
		
		private Bitmap canvas;
		
		private void paintSelect()
		{
			if (_Selected) {
				using (Graphics g = Graphics.FromImage(canvas)) {
					g.Clear(Color.Transparent);
					TextureBrush brush = new TextureBrush(mask);
					brush.TranslateTransform(Width - mask.Width, Height - mask.Height);
					Rectangle rect = new Rectangle(Width - mask.Width, Height - mask.Height, mask.Width, mask.Height);
					g.FillRectangle(brush, rect);
					g.Flush();
				}
				Img.Image = canvas;
			}
			else
			{
				using (Graphics g = Graphics.FromImage(canvas)) {
					g.Clear(Color.Transparent);
				}
			}
		}
		
		void PicturePickerLoad(object sender, EventArgs e)
		{
			paintSelect();
		}
		
		
		void PicturePickerSizeChanged(object sender, EventArgs e)
		{
			Img.Size = Size;
			canvas = new Bitmap(canvas, Size);
			paintSelect();
		}
	}
}
