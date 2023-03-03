using System.Collections.Generic;
class MainClass
{
    public static void Main(string[] args)
    {
        List<string> nameList = new List<string>();
        ListUtility.getListInput(nameList);
        ListUtility.calculateLikes(nameList);

        Dictionary<string, int> letters = new Dictionary<string, int>();
    }
}