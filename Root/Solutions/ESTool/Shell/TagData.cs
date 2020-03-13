/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/13
 * 时间: 16:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Shell
{
	/// <summary>
	/// Description of TagData.
	/// </summary>
	public abstract class TagData : IDisposable
	{
		public TagData()
		{
			
		}
		
		public String Description;
		public String Target;
		
		private bool disposed = false;
		
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		public virtual void Dispose(bool disposing)
		{
			if(!disposed)
			{
				if(disposing)
				{
					
				}
				
				disposed = true;
			}
		}
		
		~TagData()
		{
			Dispose(false);
		}
	}
	
	public class FormControlTagData : TagData
	{
		
	}
}
