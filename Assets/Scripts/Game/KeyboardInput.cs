using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    // Update is called once per frame
    public WordManager wordManager;

    void Update()
    {
        foreach (var c in Input.inputString)
        {
            wordManager.TypeLetter(c);
        }
    }
}
