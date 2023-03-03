static class DictUtility
{
    private static char[] charArray;
    private static List<char> charList;
    private static char[] keyOrder;
    static void populateDict(Dictionary<string, int> dict)
    {
        Console.Write("Please enter a sentence: ");
        charArray = Console.ReadLine().ToCharArray();
        if(charArray.Length != 0)
        {
            foreach (char c in charArray)
            {
                if ((int)c == 32)
                {
                    if (dict.ContainsKey(c + ""))
                    {
                        dict["space"]++;
                    }
                    else
                    {
                        dict.Add("space", 1);
                    }
                }
                else if ((int)c >= 33
                   && (int)c <= 126)
                {
                    if (dict.ContainsKey(c + ""))
                    {
                        dict[c + ""]++;
                    }
                    else
                    {
                        dict.Add(c + "", 1);
                    }
                }
            }

            charList = charArray.ToList();
            keyOrder = new char[charArray.Length];
            int keyOrderIndex = 0;
            for(int x = charList.Count - 1; x >= 1; x--)
            {
                int smallest = charList[x];
                for(int y = x - 1; y >= 0; y--)
                {
                    if (charList[y] < smallest)
                    {
                        smallest = charList[y];
                    }
                }
                keyOrder[keyOrderIndex] = smallest;
                keyOrderIndex++;
            }

            //print output here
        }
    }
}