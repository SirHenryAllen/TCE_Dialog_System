using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeVisibility : MonoBehaviour {
    public Button button;

    public void Start() {
        button.gameObject.SetActive(false);
    }

    public void changeState(bool state) {
        if (state) {
            button.gameObject.SetActive(true);
        } else {
            button.gameObject.SetActive(false);
        }
    }

   /* public bool getState() {
        return button.GetComponent(this).IsActive();
    } */

}
