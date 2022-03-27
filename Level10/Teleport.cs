using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    //on character
    [SerializeField] private Collider2D teleportCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == teleportCollider)
        {
            SceneManager.LoadScene(12);
        }
    }
}
