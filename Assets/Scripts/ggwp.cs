using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ggwp : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
}
