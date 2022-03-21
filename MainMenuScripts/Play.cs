using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void GoPlay()
    {
        SceneManager.LoadScene(1);
    }
}
