using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D characterRB, text, pixelCake;

    private void Start()
    {
        StartCoroutine(FallRBs());
    }
    private void FixedUpdate()
    {
        Deepest();
    }

    private void Deepest()
    {
        if (characterRB.transform.position.y < -25f)
        {
            SceneManager.LoadScene(0);
        }
    }

    private IEnumerator FallRBs()
    {
        yield return new WaitForSeconds(69);
        pixelCake.bodyType = RigidbodyType2D.Dynamic;
        yield return new WaitForSeconds(2);
        text.bodyType = RigidbodyType2D.Dynamic;
    }
}
