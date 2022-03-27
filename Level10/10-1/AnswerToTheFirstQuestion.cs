using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class AnswerToTheFirstQuestion : OpenDoor
{
    //on door
    [SerializeField] private TextMeshProUGUI dialogAnswer;
    [SerializeField] private GameObject FirstQvestionButtons;
    public void AnswerYes()
    {
        FirstQvestionButtons.SetActive(false);
        StartCoroutine(IfYes());
    }
    public void AnswerNo()
    {
        FirstQvestionButtons.SetActive(false);
        StartCoroutine(IfNo());
    }

    private IEnumerator IfYes()
    {
        yield return new WaitForSeconds(1);
        dialogAnswer.text = "then come on";
        yield return new WaitForSeconds(2);
        openOrCloseDoor = true;
        OpenTheDoor();
    }

    private IEnumerator IfNo()
    {
        yield return new WaitForSeconds(1);
        dialogAnswer.text = "well, okay...";
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(10);
    }
}
