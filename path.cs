public class Program
{
    public static void Main()
    {
        string clp = System.Windows.Forms.Clipboard.GetText();
        string result = "c:/o/docLib/" + clp;
        System.Windows.Forms.Clipboard.SetText(result);
    }
}
