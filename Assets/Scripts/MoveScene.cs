using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(MoveToNext());
    }

    IEnumerator MoveToNext()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

}
