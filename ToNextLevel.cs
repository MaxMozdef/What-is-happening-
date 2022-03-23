using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    // on character
    [SerializeField] private Collider2D goNextLevelCollider;
    [SerializeField] protected int levelIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == goNextLevelCollider)
        {
            SceneManager.LoadScene(levelIndex);
            Debug.Log($"load {levelIndex} scene");
            PlusCountOpenLevel();
        }
    }
    private void PlusCountOpenLevel()
    {
        if (SelectionLevel.countUnlockedLevel < (levelIndex - 1))
        {
            SelectionLevel.countUnlockedLevel = (levelIndex - 1);
        }
        PlayerPrefs.SetInt("cul", SelectionLevel.countUnlockedLevel);
    }
}
