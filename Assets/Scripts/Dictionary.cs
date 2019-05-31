using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class Dictionary : MonoBehaviour
{
    private static List<string> wordsPool = new List<string>();
    private static int len = 0;
    private static bool loaded = false;

    static void readTextFile(string file_path)
    {
        StreamReader inp_stm = new StreamReader(file_path);

        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine().Trim();
            // Do Something with the input. 
            if( 1 < inp_ln.Length && inp_ln.Length <= 5)
            {
                wordsPool.Add(inp_ln.ToLower());
                len++;
            }
           
        }
        inp_stm.Close();

    }

    public static string RandomWord() 
    {
        if (!loaded)
        {
            string f_path = "./Assets/word.txt";
            readTextFile(f_path);
            loaded = true;
        }
        int randI = Random.Range(0, len);
        return wordsPool[randI];
    }
}
