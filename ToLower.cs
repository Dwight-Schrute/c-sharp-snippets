public class Program
{
    public static void Main()
    {
        string clp = System.Windows.Forms.Clipboard.GetText();
        int s1 = clp.IndexOf("(");
        string result = System.String.ToLower(clp.Remove(s1).Trim());
        System.Windows.Forms.Clipboard.SetText(result);
    }
}
