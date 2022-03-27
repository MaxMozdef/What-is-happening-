using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionLevelButtons : MonoBehaviour
{
    //on canvas
    private void Start()
    {
        SelectionLevel.countUnlockedLevel = 1;
        SelectionLevel.countUnlockedLevel = PlayerPrefs.GetInt("cul");
        PlayerPrefs.SetInt("cul", SelectionLevel.countUnlockedLevel);
        
    }

    public void SelectOneLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void SelectTwoLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void SelectThreeLevel()
    {
        SceneManager.LoadScene(4);
    }
    public void SelectFourLevel()
    {
        SceneManager.LoadScene(5);
    }
    public void SelectFiveLevel()
    {
        SceneManager.LoadScene(6);
    }
    public void SelectSixLevel()
    {
        SceneManager.LoadScene(7);
    }
    public void SelectSevenLevel()
    {
        SceneManager.LoadScene(8);
    }
    public void SelectEightLevel()
    {
        SceneManager.LoadScene(9);
    }
    public void SelectNineLevel()
    {
        SceneManager.LoadScene(10);
    }
    public void SelectTenLevel()
    {
        SceneManager.LoadScene(11);
    }
    public void SelectElevenLevel()
    {
        SceneManager.LoadScene(13);
    }
    public void SelectTwelveLevel()
    {
        SceneManager.LoadScene(14);
    }
    public void SelectThirteenLevel()
    {
        SceneManager.LoadScene(15);
    }
    public void SelectFourteenLevel()
    {
        SceneManager.LoadScene(16);
    }
}
