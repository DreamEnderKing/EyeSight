/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/18
 * 时间: 15:59
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Tar;

namespace Shell
{
	#region User structure
	/// <summary>
	/// Description of UserInfo.
	/// </summary>
	public partial class UserInfo
	{
		public UserInfo(string name, string key)
		{
			_name = name;
			_key = key;
			Init();
		}
		
		protected virtual void Init()
		{
			_dir = new DirectoryInfo(SYS.path + "\\User\\" + _name);
			
		}
		
		public void Init(Image icon)
		{
			_icon = icon;
			Init();
		}
		
		protected string _name;
		public string Name
		{
			get
			{
				return _name;
			}
		}
		
		protected DirectoryInfo _dir;
		public DirectoryInfo Dir
		{
			get 
			{
				return _dir;
			}
		}
		
		protected string _key;
		public bool CheckKey(string k)
		{
			return (_key == k);
		}
		
		protected Image _icon;
		public Image Icon
		{
			get
			{
				return _icon;
			}
		}
	}
	
	/// <summary>
	/// This class can't be built from instructor.
	/// Please use UserOperator.Create().
	/// </summary>
	public class NewUserInfo : UserInfo
	{
		public NewUserInfo(string name, string key) : base(name, key)
		{
			_name = name;
			_key = key;
			_icon = Libs.ResxOperater.GetImage("B3user_newUser");
			Init();
		}
		
		public void SetIcon(Image icon)
		{
			_icon = icon;
		}
		
		public UserInfo BeginInit()
		{
			UserInfo user = new UserInfo(_name,  _key);
			DirectoryInfo dir = _dir.GetDirectories(".UserInfo")[0];
			using(FileStream  stream = new FileStream(dir.FullName + "\\data.tar", FileMode.CreateNew))
			{
				using(TarOutputStream file = new TarOutputStream(stream))
				{
					//Write password
					TarHeader Hpasswd = new TarHeader();
					Hpasswd.Name = "passwd.dat";
					TarEntry Epasswd = new TarEntry(Hpasswd);
					byte[] BSpasswd = System.Text.UnicodeEncoding.Unicode.GetBytes(_key);
					Epasswd.Size = BSpasswd.Length;
					file.PutNextEntry(Epasswd);
					file.Write(BSpasswd, 0, BSpasswd.Length);
					file.CloseEntry();
					file.Flush();
					//Write icon
					TarHeader Hicon = new TarHeader();
					Hicon.Name = "icon.png";
					TarEntry Eicon = new TarEntry(Hicon);
					FileStream tmpStream = new Temp().CreateFile();
					_icon.Save(tmpStream, ImageFormat.Png);
					tmpStream.Flush();
					tmpStream.Seek(0, SeekOrigin.Begin);
					byte[] BSicon = new byte[tmpStream.Length + 1];
					tmpStream.Read(BSicon,  0, BSicon.Length);
					tmpStream.ReadByte();
					Eicon.Size = BSicon.Length;
					file.PutNextEntry(Eicon);
					file.Write(BSicon, 0, BSicon.Length);
					file.CloseEntry();
					file.Flush();
					
					file.Close();
				}
			
			}
			
			return user;
		}
	}
	
	#endregion
	
	public static class UserOperater
	{
		public static NewUserInfo Create(string name, string key)
		{
			NewUserInfo user = new NewUserInfo(name, key);
			if (Directory.Exists(SYS.path + "\\User\\" + name)) {
				throw new IOException("Name has existed!");
			}
			Directory.CreateDirectory(SYS.path + "\\User\\" + name);
			DirectoryInfo dir = new DirectoryInfo(SYS.path + "\\User\\" + name);
			dir.CreateSubdirectory("Document");
			dir.CreateSubdirectory("Picture");
			dir.CreateSubdirectory("Video");
			dir.CreateSubdirectory("Desktop");
			dir.CreateSubdirectory("Download");
			DirectoryInfo info = dir.CreateSubdirectory(".UserInfo");
			File.SetAttributes(info.FullName, FileAttributes.Hidden);
			
			return user;
		}
		
		public static UserInfo Get(string name)
		{
			string key = "";
			
			Image icon = new Bitmap(10, 10);
			
			DirectoryInfo dir = new DirectoryInfo(SYS.path + "\\User\\" + name);
			
			using (FileStream stream = (new Temp()).LoadFile(dir.FullName + "\\.UserInfo\\data.tar")) {
				using (TarInputStream file = new TarInputStream(stream)) {
					TarEntry Epasswd = file.GetNextEntry();
					byte[] BSpasswd = new byte[Epasswd.Size];
					file.Read(BSpasswd, 0, BSpasswd.Length);
					key = System.Text.UnicodeEncoding.Unicode.GetString(BSpasswd, 0, BSpasswd.Length);
					using (FileStream ico = (new Temp()).CreateFile()) {
						file.GetNextEntry();
						file.CopyEntryContents(ico);
						Bitmap b = new Bitmap(ico);
						icon = b.Clone(new Rectangle(0, 0, b.Width, b.Height), b.PixelFormat);
						b.Dispose();
						
					}
				}
			}
			
			
			UserInfo user = new UserInfo(name, key);
			user.Init(icon);
			return user;
		}
		
	}
	
	#region Exceptions
	public enum UserExpType
	{
		Notfound,
		KeyHadSet
	}
	public class UserException : Exception
	{
		public UserException(UserExpType t)
		{
			switch (t) {
				case UserExpType.Notfound:
					//Message = "User not found.";
					break;
				case UserExpType.KeyHadSet:
					//Message = "The key can't be set twice.";
					break;
				default:
					throw new Exception("Invalid value for UserExpType");
			}
		}
	}
	
	#endregion
		
}
