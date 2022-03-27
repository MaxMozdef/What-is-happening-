using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintText : MonoBehaviour
{
    //on character
    [SerializeField] private Collider2D hintCollider;
    [SerializeField] private TextMeshProUGUI hint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == hintCollider)
        {
            hint.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == hintCollider)
        {
            hint.enabled = false;
        }
    }
}
