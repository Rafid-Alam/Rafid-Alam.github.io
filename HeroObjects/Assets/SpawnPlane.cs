using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlane : MonoBehaviour
{
    /*
    Camera mTheCamera = gameObject.GetComponent<Camera>();
    float maxY = mTheCamera.orthographicSize;
    float maxX = mTheCamera.orthographicSize * mTheCamera.aspect;
    float sizeX = 2 * maxX;
    float sizeY = 2 * maxY;
    Vector3 c = mTheCamera.transform.position;
    //c.z = 0.0f;
    //mWorldBound.center = c;
    //mWorldBound.size = new Vector3(sizeX, sizeY, 1f); // z is arbitrary!!
    */
    private float enemiesLeft = 0;
    float eggsLeft = 0;
    public GameObject PlanePrefab;

    // Update is called once per frame
    void Update()
    {
        GameObject[] Planes = GameObject.FindGameObjectsWithTag("Plane");
         enemiesLeft = Planes.Length;
         if(enemiesLeft < 10){
            GameObject p = GameObject.Instantiate(PlanePrefab) as GameObject;
            float x = Random.Range(-180, 160);
            float y = Random.Range(-90, 90);
            p.transform.position = new Vector3(x, y, 0f);
         }
    }

    void OnGUI()
    {
        GameObject[] Eggs = GameObject.FindGameObjectsWithTag("Egg");
        eggsLeft = Eggs.Length;
        GUI.Label(new Rect(10, 10, 100, 20), "Emeies Left = " + enemiesLeft);
        GUI.Label(new Rect(10, 30, 150, 20), "Eggs On Screen = " + eggsLeft);
    }
}
