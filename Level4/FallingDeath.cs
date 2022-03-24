using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingDeath : MonoBehaviour
{
    [SerializeField] private Collider2D characterCollider;

    private void Update()
    {
        jumpDownDefeat();
    }

    private void jumpDownDefeat()
    {
        if (characterCollider.transform.position.y <= -7f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
