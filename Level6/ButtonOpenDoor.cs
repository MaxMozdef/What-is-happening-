using System.Collections.Generic;
using UnityEngine;

public class ButtonOpenDoor : OpenDoor
{//on door
    [SerializeField] private List<GameObject> platforms = new List<GameObject>();

    public void OpenDoorOnSixLevelllll()
    {
        openOrCloseDoor = true;
        OpenTheDoor();
        FallPlatforms();
    }
    private void FallPlatforms()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            platforms[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
