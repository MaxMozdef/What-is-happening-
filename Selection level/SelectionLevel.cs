using UnityEngine;
using UnityEngine.UI;

public class SelectionLevel : MonoBehaviour
{
    public static int countUnlockedLevel = 1;

    private void Start()
    {
        countUnlockedLevel = PlayerPrefs.GetInt("cul");
        OpenCloseLevel();
    }
    private void OpenCloseLevel()
    {
        for (int i = 0; i < transform.childCount; i++)
        {

            if (i < countUnlockedLevel)
            {
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }
}
