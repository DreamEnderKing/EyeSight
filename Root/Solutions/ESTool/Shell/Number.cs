/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/9
 * 时间: 8:43
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
	/// Description of Number.
	/// </summary>
	public partial class Number
	{
		public Number()
		{
		}
		
		
		static char[] char64 = new char[]{
			 '0' , '1' , '2' , '3' , '4' , '5' ,  
        '6' , '7' , '8' , '9' , 'a' , 'b' ,  
        'c' , 'd' , 'e' , 'f' , 'g' , 'h' ,  
        'i' , 'j' , 'k' , 'l' , 'm' , 'n' ,  
        'o' , 'p' , 'q' , 'r' , 's' , 't' ,  
        'u' , 'v' , 'w' , 'x' , 'y' , 'z' ,  
        'A' , 'B' , 'C' , 'D' , 'E' , 'F' ,  
        'G' , 'H' , 'I' , 'J' , 'K' , 'L' ,  
        'M' , 'N' , 'O' , 'P' , 'Q' , 'R' ,  
        'S' , 'T' , 'U' , 'V' , 'W' , 'X' ,  
        'Y' , 'Z' , '=' , '_'  ,  
		};
		public string From10To64(int input)
		{
			int a = 0, i=0;
			char[] c = new char[8];
			Stack<char> s = new Stack<char>();
			do
			{
				a = input % 64;
				s.Push(char64[a]);
				input >>= 4;
				i++;
			}while(i<=7);
			for (int j = 0; j < 8; j++) {
				c[j] = s.Pop();
			}
			return new String(c);
		}
	}
}
