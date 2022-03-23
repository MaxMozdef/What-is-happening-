using UnityEngine;

public class Exit : MonoBehaviour
{
    //on character
    [SerializeField] private Collider2D quitCollider;

    private void Update()
    {
        DeleteAllSave();
    }
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
    private void DeleteAllSave()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SelectionLevel.countUnlockedLevel = 1;
            PlayerPrefs.SetInt("cul", SelectionLevel.countUnlockedLevel);
        }
    }
}
