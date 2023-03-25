using System;
using System.IO;


public  class ProccesData
{

    public static void ReadWords(string path)
    {
        StreamReader reader = new StreamReader(path);
        string row = "a";
        string enWord = string.Empty;
        string bgWord = string.Empty;
        int indexOfA = 0;
        var dic = new Dictionary<string,List< string>>();


        using (reader)
        {
            while (true)
            {
                row = reader.ReadLine();
                if (row == null) break;
                indexOfA = row.IndexOf("@");
                enWord = row.Substring(0, indexOfA - 1).ToLower();
                bgWord = row.Substring(indexOfA + 1).ToLower();

                while (bgWord[0] == ' ' || bgWord[0] == '\t')
                {
                    bgWord = bgWord.Substring(1, bgWord.Length - 1);

                }

                while (bgWord[bgWord.Length - 1] == ' ' || bgWord[bgWord.Length - 1] == '\t')
                {
                    bgWord = bgWord.Substring(0, bgWord.Length - 1);
                }


                while (enWord[enWord.Length-1] == ' ' || enWord[enWord.Length-1] == '\t')
                {
                    enWord = enWord.Substring(0, enWord.Length-1);
                    
                }
                if (!dic.ContainsKey(enWord)) 
                {
                    dic.Add(enWord, new List<string>());
                }
                dic[enWord].Add(bgWord);

               

            }
        }

        string pathTosave = "C:\\Users\\Milen Machkov\\OneDrive\\Работен плот\\aEmpty\\03.EN\\wordsAlignment.txt";
        StreamWriter writer = new StreamWriter(pathTosave);
        using (writer)
        {
            foreach (KeyValuePair<string,List<string>> pairs in dic)
            {
                writer.Write(pairs.Key + "=");
                foreach (var value in pairs.Value)
                {

                    writer.Write(value + ',');
                }
                writer.Write("\n");
            }
        }

       

    }
}