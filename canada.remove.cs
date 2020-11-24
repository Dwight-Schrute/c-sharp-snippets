public class Program
{
    public static void Main()
    {
        string clp = System.Windows.Forms.Clipboard.GetText();
        if (clp.Contains(", Canada"))
        {
            int s1 = clp.IndexOf(", Canada");
            System.Windows.Forms.Clipboard.SetText(clp.Remove(s1).Trim());
        }
        else
        {
            System.Windows.Forms.Clipboard.SetText(clp.Trim());
        }
    }
}
