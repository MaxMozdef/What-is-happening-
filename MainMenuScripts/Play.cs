using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] private Collider2D playCollider;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == playCollider)
        {
            GoPlay();
        }
    }
    public void GoPlay()
    {
        SceneManager.LoadScene(1);
    }
}
