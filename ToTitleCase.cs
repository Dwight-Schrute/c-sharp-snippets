public class Program
{
	public static void Main()
	{		
		string clp = System.Windows.Forms.Clipboard.GetText();
		string result = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(clp.ToLower());
		System.Windows.Forms.Clipboard.SetText(result);
	}
}
