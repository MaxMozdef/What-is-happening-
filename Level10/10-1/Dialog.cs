using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    //on canvas/BG
    [SerializeField] private TextMeshProUGUI dialogText;
    [SerializeField] private GameObject FirstQvestionButtons;

    private void Start()
    {
        StartCoroutine(DialogStrings());
    }

    private IEnumerator DialogStrings()
    {
        yield return new WaitForSeconds(7);
        dialogText.text = "hello!";
        yield return new WaitForSeconds(3);
        dialogText.text = "do you want to open the door?";
        yield return new WaitForSeconds(2);
        FirstQvestionButtons.SetActive(true);
    }
}
