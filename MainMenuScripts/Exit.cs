using UnityEngine;

public class Exit : MonoBehaviour
{
    //on character
    [SerializeField] private Collider2D quitCollider;
    public void GoExit()
    {
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == quitCollider)
        {
            GoExit();
            Debug.Log("quit!");
        }
    }
}
