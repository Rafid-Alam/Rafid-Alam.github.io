using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{

    void OnTriggerEnter2d(Collision2D collision){
        //if (collision.gameObject.name != "Hero"){
            Destroy(gameObject);
        //}
    }

    void OnBecameInvisible() { Destroy(gameObject); }
    
}
