using System;
using System.IO;
using System.Text;


public class Program
{
	public static void Main()
	{
		string path = @"C:\t\counter.txt";

		using (StreamReader sr = new StreamReader(path))
		{
			System.Windows.Forms.Clipboard.SetText(sr.ReadLine());
		}
	}
}
