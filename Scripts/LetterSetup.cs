using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Text;

public class LetterSetup : MonoBehaviour
{
    public TMP_Text DisplayedText;
    public bool SetColorWhite;
    public string Text;

    // Start is called before the first frame update
    void Start(){
        DisplayedText.text = Text;
        if (SetColorWhite == true) {
            DisplayedText.color = Color.white;
            DisplayedText.fontSize = 0.2f;
        }
    }
}
