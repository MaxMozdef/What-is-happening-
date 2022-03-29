using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeckGroundMassage : MonoBehaviour
{
    //on bg canvas
    [SerializeField] private TextMeshProUGUI beckMessages;

    private void Start()
    {
        StartCoroutine(AppearingMessages());
    }

    private IEnumerator AppearingMessages()
    {
        yield return new WaitForSeconds(2);
        beckMessages.text = "this is the final boss!";

        //if (true)
        //{
        //    //wten destroy
        //    yield return new WaitForSeconds(2);
        //    beckMessages.text = "you can go through the door!";
        //    yield return new WaitForSeconds(2);
        //    beckMessages.text = "you're a winner! you are a cutie ;)";
        //}
    }
}
