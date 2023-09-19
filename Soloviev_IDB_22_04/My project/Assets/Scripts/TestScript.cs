using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject sphere;
   // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            sphere = GameObject.Find("Sphere");
            inst();
        }
        print("Update");
    }
    void inst(){
        for (int i = 0; i < 10; i++){
            Vector3 nv = new Vector3(i,0,0);
            Instantiate(sphere, nv, sphere.transform.rotation);
        }

    }
}
