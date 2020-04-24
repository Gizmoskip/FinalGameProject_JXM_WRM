using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTax : MonoBehaviour
{
    public Transform point;

    public GameObject Tax;

    public GameObject Soap;

    public float force = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot2();
        }
    }

    void Shoot()
    {
        GameObject taxShot = Instantiate(Tax, point.position, point.rotation);
        Rigidbody2D rb = taxShot.GetComponent<Rigidbody2D>();
        rb.AddForce(point.up * force, ForceMode2D.Impulse);
    }

    void Shoot2()
    {
        GameObject soapShot = Instantiate(Soap, point.position, point.rotation);
        Rigidbody2D rb = soapShot.GetComponent<Rigidbody2D>();
        rb.AddForce(point.up * force, ForceMode2D.Impulse);
    }
}
