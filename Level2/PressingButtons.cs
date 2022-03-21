using UnityEngine;

public class PressingButtons : MonoBehaviour
{
    //on character
    [SerializeField] private GameObject leftButtonTrigger, rightButtonTrigger;
    [SerializeField] private Collider2D leftTrigger, rightTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == leftTrigger)
        {
            leftButtonTrigger.transform.localPosition = new Vector3(-0.0468f, 0.0554f, 3.469265f);
        }
        if (collision == rightTrigger)
        {
            rightButtonTrigger.transform.localPosition = new Vector3(0.0468f, 0.0565f, 3.469265f);
        }
    }
}
