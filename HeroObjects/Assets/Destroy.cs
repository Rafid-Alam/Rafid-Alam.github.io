using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2d(Collision2D collision){
        //if (collision.gameObject.name != "Hero"){
            Destroy(gameObject);
        //}
    }

    void OnBecameInvisible() { Destroy(gameObject); }
}
