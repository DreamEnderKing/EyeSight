/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/20
 * 时间: 11:34
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.ComponentModel;
using System.Drawing;

namespace Libs
{
	/// <summary>
	/// Description of Resx.
	/// </summary>
	public class Resx
	{
		
	}
	
	public static class ResxOperater
	{
		public static Image  GetImage(string str)
		{
			ComponentResourceManager resource = new ComponentResourceManager(typeof(Resx));
			try
			{
				Image o = (Image)resource.GetObject(str);
				return o;
			}
			catch(Exception) {
				
			}
			return new Bitmap(0, 0);
			
		}
		
		public static string Getstring(string str)
		{
			ComponentResourceManager resource = new ComponentResourceManager(typeof(Resx));
			try {
				return ((string)resource.GetObject(str));
			} catch (Exception) {
				
			}
			return "";
		}
	}
}
