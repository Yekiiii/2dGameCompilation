using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private int shootAmo = 30;
    public Text bulletAmoText;
    public bool bulletAmoEnabled = false;
    public AudioSource TopDownShootAudio;

    public float bulletForce = 20f;
    // Start is called before the first frame update

    public void BulletRefill() {
        shootAmo = shootAmo + 5;
    }

    void Shoot() {
        TopDownShootAudio.Play();
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb =bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        shootAmo--;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootAmo>0) {
            bulletAmoEnabled = true;
        }
        if (shootAmo < 1)
        {

            bulletAmoEnabled = false;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (bulletAmoEnabled == true)
            {
                Shoot();
                bulletAmoText.text = "Ammo: "+shootAmo.ToString();
            }
        }
    }
}
