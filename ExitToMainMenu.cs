using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMainMenu : MonoBehaviour
{
    //on "Exit To Main Menu Button" 
    public void ExitMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
