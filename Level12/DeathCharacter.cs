using TMPro;
using UnityEngine;

public class DeathCharacter : MonoBehaviour
{
    //on character
    [SerializeField] private GameObject bossCollider, dieBeckGroundImeg;
    [SerializeField] private TextMeshProUGUI textYouDied;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Final Boss")
        {
            dieBeckGroundImeg.SetActive(true);
            textYouDied.gameObject.SetActive(true);
        }
    }
}
