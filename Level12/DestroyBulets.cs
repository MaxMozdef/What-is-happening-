using UnityEngine;

public class DestroyBulets : MonoBehaviour
{
    //on bullet

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "FinalBoss")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Door")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
