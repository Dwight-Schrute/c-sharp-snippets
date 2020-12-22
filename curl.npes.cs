public class Program
{
	public static void Main()
	{
string clp = System.Windows.Forms.Clipboard.GetText();
string temp = clp.Replace("\r\n", "").Replace("\n", "");
string[] split = temp.Split(new char[] { '\t' });
string result = "curl " + "\"https://npiregistry.cms.hhs.gov/api/?first_name=" + split[0] + "&last_name=" + split[1] + "&skip=&version=2.1\"" + " | grep -Eo \'\\\"number\\\":\\s[0-9]{10}\'" + " | grep -Eo '[0-9]{10}' | clip && exit";
System.Windows.Forms.Clipboard.SetText(result);
	}
}
