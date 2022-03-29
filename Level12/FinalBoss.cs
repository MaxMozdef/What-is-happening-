using System.Collections;
using UnityEngine;
using TMPro;

public class FinalBoss : MonoBehaviour
{
    //on camera
    [SerializeField] private GameObject finalBoss, shotButton;
    [SerializeField] private Vector3 respBoss, endPathBoss;
    [SerializeField] private float stepMove;
    [SerializeField] private TextMeshProUGUI winSpichText;
    [SerializeField] private KillBoss killBoss;
    private float progress;
    void Start()
    {
        finalBoss.SetActive(false);
        shotButton.SetActive(false);
        StartCoroutine(BossAction());
    }

    private void FixedUpdate()
    {
        StartCoroutine(BossMove());
        IfBossKilled();
    }

    private IEnumerator BossAction()
    {
        yield return new WaitForSeconds(4);
        finalBoss.SetActive(true);
        shotButton.SetActive(true);
    }

    private IEnumerator BossMove()
    {
        yield return new WaitForSeconds(6.3f);
        finalBoss.transform.position = Vector3.Lerp(respBoss, endPathBoss, progress);
        progress += stepMove;
    }

    private void IfBossKilled()
    {
        if (killBoss.isBossKill)
        {
            StartCoroutine(WinSpich());
        }
        killBoss.isBossKill = false;
    }
    private IEnumerator WinSpich()
    {
        yield return new WaitForSeconds(1.5f);
        winSpichText.text = "You're a winner!";
        yield return new WaitForSeconds(2);
        winSpichText.text = "You can go through the door!";
    }
}
