using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText : MonoBehaviour {

    public Text mytext = null;
    public void changeText() {
        mytext.text = "Hello World";
    }
}