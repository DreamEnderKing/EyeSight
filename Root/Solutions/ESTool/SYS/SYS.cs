/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 01/30/2020
 * 时间: 17:35
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.IO;

namespace SYS
{
	/// <summary>
	/// Description of SYS.
	/// </summary>
	public static class SYS
	{
		public static string version = "1.0.0";
		
		public static string corparation = "Dream Corparation";
		
		public static string path = new Action().getpath();
			
	}
	
	class Action
	{
		public string getpath()
		{
			DirectoryInfo d = new DirectoryInfo(Environment.CurrentDirectory);
			string str = d.Name;
			while(!str.ToUpper().Equals("EYESIGHT"))
			{
				d = d.Parent;
				str = d.Name;
			}
			return d.FullName;
		}
	}
}
