public class Program
{
    public static void Main()
    {
        string clp = System.Windows.Forms.Clipboard.GetText();
        string root = @"<<ENVIRONMENTAL VARIABLE>>";
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
