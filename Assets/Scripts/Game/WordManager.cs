using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{
    public List<Word> words;
    private bool hasActiveWord;
    private Word activeWord;
    public Spawner spawner;
    [SerializeField] AudioClip[] sounds;
    [SerializeField] AudioClip destroy;
    private int score = 0;
    [SerializeField]Text scoreText;
    public void AddWord()
    {
        Word w = new Word(Dictionary.RandomWord(), spawner.SpawnWord()); 
        words.Add(w);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if(activeWord.GetCurrentLetter() == letter)
            {
                activeWord.Type();
                PlayKeySound();

            }
        }
        else 
        { 
            foreach(Word w in words)
            {
                if (w.GetCurrentLetter() == letter)
                {
                    activeWord = w;
                    hasActiveWord = true;
                    w.Type();
                    PlayKeySound();
                    break;
                }

            }
        }

        if (hasActiveWord && activeWord.HasTyped())
        {
            hasActiveWord = false;
            GetComponent<AudioSource>().PlayOneShot(destroy);
            score += activeWord.word.Length;
            words.Remove(activeWord);
            scoreText.text = score.ToString();
        }
    }

    public void PlayKeySound()
    {
        AudioClip clip = sounds[Random.Range(0, sounds.Length)];
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
