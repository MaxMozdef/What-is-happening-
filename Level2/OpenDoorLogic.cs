using UnityEngine;

public class OpenDoorLogic : OpenDoor
{
    //on character
    [SerializeField] private Collider2D leftTrigger, rightTrigger;
    [SerializeField] private bool leftButtonTrigger, rightButtonTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == leftTrigger)
        {
            leftButtonTrigger = true;
        }
        if (collision == rightTrigger)
        {
            rightButtonTrigger = true;
        }
    }

    private void FixedUpdate()
    {
        if (leftButtonTrigger == true && rightButtonTrigger == true)
        {
            openOrCloseDoor = true;
            OpenTheDoor();
        }
    }
}
