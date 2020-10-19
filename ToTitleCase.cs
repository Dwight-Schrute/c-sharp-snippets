//without declaring namespace directives like "using System;", "using System.Threading;" as they are invoked directly.
//using System.Windows.Forms;
//using System.Threading;


public class Program
{
	public static void Main()
	{
				
		string clp = System.Windows.Forms.Clipboard.GetText();

		string result = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(clp.ToLower());

		System.Windows.Forms.Clipboard.SetText(result);

		//System.Windows.Forms.MessageBox.Show(result);
	}
}