using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int i = 0;
    private WordDisplay display;

    public Word(string w, WordDisplay d)
    {
        word = w;
        display = d;
        display.SetWord(word);
    }

    public char GetCurrentLetter()
    {
        return word[i];
    }
    public void Type()
    {
        i++;
        display.RemoveLetter();

    }
    public bool HasTyped()
    {
        bool done = i >= word.Length;
        if (done)
        {
            //good bye word
            display.RemoveWord();
        }
        return done;
    }
}
