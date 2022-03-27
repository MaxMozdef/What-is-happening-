using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WaitForOpenDoor : OpenDoor
{
    //on character
    [SerializeField] private TextMeshProUGUI backGroundLine;
    [SerializeField] private Collider2D warningCollider, restartLevelCollider;
    private bool canGo;
    private void Start()
    {
        StartCoroutine(WaitOnOpenDoor());
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == warningCollider && canGo == false)
        {
            backGroundLine.text = "stop!!!";
        }
        if (collision == restartLevelCollider && canGo == false)
        {
            backGroundLine.text = "oh no :(";
            StartCoroutine(OhNoRestartLevel());
        }
    }

    private IEnumerator WaitOnOpenDoor()
    {
        yield return new WaitForSeconds(33);
        canGo = true;
        openOrCloseDoor = true;
        backGroundLine.text = "go!";
        OpenTheDoor();
    }
    
    private IEnumerator OhNoRestartLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
