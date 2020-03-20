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

namespace Shell
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
			DirectoryInfo d = new DirectoryInfo(SYS.path + "\\Root\\Temp");
			System.Collections.Generic.IEnumerable<FileInfo> files = d.EnumerateFiles();
			System.Collections.Generic.IEnumerable<DirectoryInfo> dirs = d.EnumerateDirectories();
			foreach(var file in files)
			{
				try {
					file.Delete();
				} catch (Exception) {
				}
			}
			foreach (var dir in dirs) {
				try {
					dir.Delete(true);
				} catch (Exception) {
				}
			}
		}
		
		public FileStream LoadFile(string filename)
		{
			//check the file
			if(!File.Exists(filename)) throw new FileNotFoundException();
			
			//create random seed
			DateTime now = DateTime.Now;
			Number n = new Number();
			string seed = n.From10To64(new Random(now.Year).Next()) + n.From10To64(new Random(now.Month).Next()) + n.From10To64(new Random(now.Day).Next()) + n.From10To64(new Random(now.Hour).Next()) + n.From10To64(new Random(now.Minute).Next()) + n.From10To64(new Random(now.Second).Next()) + n.From10To64(new Random(now.Millisecond).Next());
			
			//copy to temporary file
			File.Copy(filename, SYS.path + "\\Root\\Temp\\" + seed);
			return new FileStream(SYS.path + "\\Root\\Temp\\" + seed,FileMode.OpenOrCreate);
			
		}
		
		public FileStream CreateFile()
		{
			//create random seed
			DateTime now = DateTime.Now;
			Number n = new Number();
			string seed = n.From10To64(new Random(now.Year).Next()) + n.From10To64(new Random(now.Month).Next()) + n.From10To64(new Random(now.Day).Next()) + n.From10To64(new Random(now.Hour).Next()) + n.From10To64(new Random(now.Minute).Next()) + n.From10To64(new Random(now.Second).Next()) + n.From10To64(new Random(now.Millisecond).Next());
			return new FileStream(SYS.path + "\\Root\\Temp\\" + seed,FileMode.OpenOrCreate);
			
		}

	}
}
