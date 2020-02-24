/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2020/1/30
 * Time: 17:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DEBUGTOOL
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Console.WriteLine(SYS.SYS.path);
			
			new Temp.Temp().ClearTemp();
			/*
			string s = new Temp.Temp().LoadFile("D:\\p.ini");
			System.IO.FileStream fs = new System.IO.FileStream(s, System.IO.FileMode.Open);
			fs.WriteByte(Convert.ToByte('a'));
			*/
			string s = Console.ReadLine();
			if(s.Equals("f"))
			{
				Form1 f = new Form1();
				f.ShowDialog();
				//while(
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("???");
				Console.Write("Press any key to continue . . . ");
				Console.ReadKey(true);
			}
			
		}
	}
}