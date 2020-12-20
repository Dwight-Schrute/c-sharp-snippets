using System;
using System.IO;
using System.Text;

public class Program
{
	public static void Main()
	{
		string clp = System.Windows.Forms.Clipboard.GetText();
		string path = @"C:\t\counter.txt";
		File.WriteAllText(path, clp);
	}
}
