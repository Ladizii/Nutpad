using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{

    public string elText;
    public GameObject ourNote;
    public GameObject placeHolder;
    public GameObject saveAnim;

    void Start()
    {
        elText = PlayerPrefs.GetString("NoteContents");
        placeHolder.GetComponent<InputField>().text = elText;
    }

    public void SaveNote()
    {
        elText = ourNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("NoteContents", elText);
        StartCoroutine(SaveTextRoll());
    }

    IEnumerator SaveTextRoll()
    {
        saveAnim.GetComponent<Animator>().Play("SavedAnim");
        yield return new WaitForSeconds(1);
        saveAnim.GetComponent<Animator>().Play("New State");
    }
}
