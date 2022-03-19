using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private Collider2D triggerToOpenDoor, characterCollider;
    [SerializeField] private GameObject door;
    [SerializeField] private Vector3 startPosition, endPosition;
    [SerializeField] private float stepMove;
    private float progress;
    private bool openOrCloseDoor;

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

    private void OpenTheDoor()
    {
        if (openOrCloseDoor == true)
        {
            door.transform.position = Vector3.Lerp(startPosition, endPosition, progress);
            progress += stepMove;
        }
    }
}