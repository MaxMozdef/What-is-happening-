using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionLevelButtons : MonoBehaviour
{
    public void SelectOneLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void SelectTwoLevel()
    {
        SceneManager.LoadScene(3);
    }
}
