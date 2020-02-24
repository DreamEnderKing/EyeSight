/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 01/30/2020
 * 时间: 17:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.IO;
using SYS;


namespace Temp
{
	/// <summary>
	/// Description of Temp.
	/// </summary>
	public class Temp
	{
		public Temp()
		{
			
		}			
		
		//<summary>Clear all the temporary files.</summary>
		public void ClearTemp()
		{
			DirectoryInfo d = new DirectoryInfo(SYS.SYS.path + "\\Root\\Temp");
			System.Collections.Generic.IEnumerable<FileInfo> files = d.EnumerateFiles();
			foreach(var file in files)
			{
				file.Delete();
			}
		}
		
		public string LoadFile(string filename)
		{
			//check the file
			if(!File.Exists(filename)) throw new FileNotFoundException();
			
			//create random seed
			DateTime now = DateTime.Now;
			string seed = new Random(now.Year).Next().ToString() + new Random(now.Month).Next().ToString() + new Random(now.Day).Next().ToString() + new Random(now.Hour).Next().ToString() + new Random(now.Minute).Next().ToString() + new Random(now.Second).Next().ToString() + new Random(now.Millisecond).Next().ToString();
			
			//copy to temporary file
			File.Copy(filename, SYS.SYS.path + "\\Root\\Temp\\" + seed);
			return SYS.SYS.path + "\\Root\\Temp\\" + seed;
			
		}

	}
}
