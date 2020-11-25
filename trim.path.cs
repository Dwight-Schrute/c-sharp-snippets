public class Program
{
    public static void Main()
    {
        string clp = System.Windows.Forms.Clipboard.GetText();
        string root = @"C:\o\globaldebtsolutions.com\gds - a\docLib\";
        if (clp.Contains(root)
        {
            System.Windows.Forms.Clipboard.SetText(clp.Replace(root, ""));
        }
        else
        {
            System.Windows.Forms.Clipboard.SetText(clp.Trim());
        }
    }
}
