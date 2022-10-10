using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float move = 0f;
    public float rotateSpeed = 90f;
    public bool mouse = true;

    void Update()
    {
        Vector3 pos = transform.position;

        if(Input.GetKeyDown(KeyCode.M)){
            mouse = !mouse;
        }

        if(mouse){
            Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            p.z = 0f;
            transform.position = p;
        }
        else{
            move = Input.GetAxis("Vertical") * speed;
            transform.position += transform.up * (move * Time.smoothDeltaTime);

            transform.Rotate(Vector3.forward, -1f * Input.GetAxis("Horizontal") *
            (rotateSpeed * Time.smoothDeltaTime));
            //transform.rotation = Quaternion.Euler(Vector3.forward * Input.GetAxis("Horizontal") *
            //(rotateSpeed * Time.smoothDeltaTime));
        }

        if(Input.GetKeyDown(KeyCode.Q)){
            Application.Quit();
        }
    }
}
