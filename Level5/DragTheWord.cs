using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTheWord : MonoBehaviour
{
    private Touch toch;
    private float speedModifier;

    void Start()
    {
        speedModifier = 0.01f;
    }

    void Update()
    {
        Drag();
    }

    private void Drag()
    {
        if (Input.touchCount > 0)
        {
            toch = Input.GetTouch(0);
            if (toch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + toch.deltaPosition.x * speedModifier,
                                                 transform.position.y + toch.deltaPosition.y * speedModifier,
                                                 transform.position.z);
            }
        }
    }
}
