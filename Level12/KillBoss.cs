using UnityEngine;

public class KillBoss : MonoBehaviour
{
    //on boss
    public bool isBossKill;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            isBossKill = true;
        }
    }
}
