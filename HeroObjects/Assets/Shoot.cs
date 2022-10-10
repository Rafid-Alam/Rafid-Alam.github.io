using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject eggPrefab;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            ShootEgg();
        }
    }

    
    void ShootEgg()
    {
        GameObject egg = Instantiate(eggPrefab,FirePoint.position,FirePoint.rotation);
        Rigidbody2D rb = egg.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Impulse);
    }
    
}
