/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2020/1/30
 * Time: 17:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.Windows.Forms;
using Shell;

namespace DEBUGTOOL
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Console.WriteLine(Shell.SYS.path);
			
			//MessageBox.Show(new Number().From10To64(Int32.MaxValue));
			new Temp().LoadFile("E:\\123.vbs");
			/*
			string s = new Temp.Temp().LoadFile("D:\\p.ini");
			System.IO.FileStream fs = new System.IO.FileStream(s, System.IO.FileMode.Open);
			fs.WriteByte(Convert.ToByte('a'));
			*/
			string s = Console.ReadLine();
			
			if(s.Equals("f"))
			{
				Application.EnableVisualStyles();
				Application.Run(new Form1());
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("???");
				Console.Write("Press any key to continue . . . ");
				Console.ReadKey(true);
			}
			
		}
		
		private static async void showWindow()
		{
			Form1 f = new Form1();
			f.Show();

		}
	}
}