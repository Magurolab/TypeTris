using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wprefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord ()
    {
        Vector3 randomPos = new Vector3(Random.Range(-3.2f, 3.2f), 7f);
        GameObject wordObj = Instantiate(wprefab,randomPos, Quaternion.identity, wordCanvas);
        WordDisplay wd = wordObj.GetComponent<WordDisplay>();

        return wd;
    }

}
