using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    //on character
    [SerializeField] private Collider2D triggerToOpenDoor, characterCollider;
    [SerializeField] private GameObject door;
    [SerializeField] private Vector3 startPosition, endPosition;
    [SerializeField] private float stepMove;
    private float progress;
    protected bool openOrCloseDoor;

    private void FixedUpdate()
    {
        OpenTheDoor();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == triggerToOpenDoor)
        {
            openOrCloseDoor = true;
        }
    }

    protected void OpenTheDoor()
    {
        if (openOrCloseDoor == true)
        {
            door.transform.position = Vector3.Lerp(startPosition, endPosition, progress);
            progress += stepMove;
        }
    }
}
