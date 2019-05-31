using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    private float g = 1.5f;
    Color[] colors = { Color.red, Color.magenta, Color.yellow, Color.green};
    private int len;

    public void SetWord(string w)
    {
        text.text = w;
        len = w.Length;
    }

    public void RemoveLetter()
    {
        len--;
        text.text = text.text.Remove(0, 1);
        text.color = colors[Random.Range(0, colors.Length)];

    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -g * Time.deltaTime, 0f);
    }

}
