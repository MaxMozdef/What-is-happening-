using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
