using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour {

    public GameObject insideText;
    public GameObject thePanel;

    public void ClearText()
    {
        insideText.GetComponent<InputField>().text = "";
    }

    public void CancelButton()
    {
        thePanel.SetActive(false);
    }

    public void ClosedButton()
    {
        thePanel.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
