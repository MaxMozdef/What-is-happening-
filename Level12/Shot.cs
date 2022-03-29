using System.Collections;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //on character
    [SerializeField] private GameObject pistol, markWeapon, fireballBullet, spaunBullet;
    [SerializeField] private Rigidbody2D fireballBulletRigBody;
    [SerializeField] private Vector2 buletSpaun;
    private Vector3 weaponMarkVector;
    private GameObject[] pistols;

    private void Start()
    {
        
    }
    private void Update()
    {
        weaponMarkVector = new Vector3(markWeapon.transform.position.x + 0.3f,
                                       markWeapon.transform.position.y + 0.2f,
                                       markWeapon.transform.position.z);

        buletSpaun = new Vector2(spaunBullet.transform.position.x, spaunBullet.transform.position.y);

        pistols = GameObject.FindGameObjectsWithTag("Pistol");
    }
    private void FixedUpdate()
    {
        bulletFlies();
    }

    public void CharacterShot()
    {
        Instantiate(pistol, weaponMarkVector, Quaternion.identity);
        bulletCreate();
        StartCoroutine(hidePistol());
    }
    private void bulletCreate()
    {
        Instantiate(fireballBullet, buletSpaun, Quaternion.identity);

    }
    private void bulletFlies()
    {
        fireballBulletRigBody.velocity = transform.right * 22;
    }
    private IEnumerator hidePistol()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < pistols.Length; i++)
        {
            Destroy(pistols[i]);
        }
    }
}
