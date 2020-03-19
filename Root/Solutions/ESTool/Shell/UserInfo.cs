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
using ICSharpCode.SharpZipLib;

namespace Shell
{
	#region User structure
	/// <summary>
	/// Description of UserInfo.
	/// </summary>
	public partial class UserInfo
	{
		public UserInfo(string name)
		{
			
		}
		
		private bool keySet = false;
		
		private String Key;
		public virtual void SetKey(String key)
		{
			if (keySet) {
				throw new UserException(UserExpType.KeyHadSet);
				return;
			}
			Key = key;
			keySet = true;
		}
	}
	
	public class NewUserInfo : UserInfo
	{
		private string _name;
		public void SetName(String name)
		{
			_name = name;
		}
		
		private string _key;
		public override void SetKey(String key)
		{
			_key = key;
		}
		
		private Image _icon;
		public void SetIcon(Image icon)
		{
			_icon = icon;
		}
	}
	
	#endregion
	
	public static class UserOperater
	{
		public static void Create(string name)
		{
			
		}
		
		public static UserInfo Get(string name)
		{
			
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
					Message = "User not found.";
					break;
				case UserExpType.KeyHadSet:
					Message = "The key can't be set twice.";
					break;
				default:
					throw new Exception("Invalid value for UserExpType");
			}
		}
	}
	
	#endregion
		
}
