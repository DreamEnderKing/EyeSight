/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/13
 * 时间: 17:49
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Runtime.InteropServices;

namespace Libs
{
	/// <summary>
	/// Description of HandleLib.
	/// </summary>
	public static class HandleLib
	{
		[System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);
	}
}
