using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    // on character
    [SerializeField] private Collider2D goNextLevelCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == goNextLevelCollider)
        {
            SceneManager.LoadScene(3);
            Debug.Log("load next scene");
        }
    }
}
