public class Program
{
    public static void Main()
    {
        string clp = System.Windows.Forms.Clipboard.GetText();
        if (clp.Contains("("))
        {
            int s1 = clp.IndexOf("(");
            string result = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToLower(clp);
            System.Windows.Forms.Clipboard.SetText(result.Remove(s1).Trim());
        }
        else
        {
            string result = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToLower(clp);
            System.Windows.Forms.Clipboard.SetText(result.Trim());
        }
    }
}
