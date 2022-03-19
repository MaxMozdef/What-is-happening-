using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    [SerializeField] private Collider2D goNextLevelCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == goNextLevelCollider)
        {
            //SceneManager.LoadScene(2);
            Debug.Log("load next scene");
        }
    }
}
