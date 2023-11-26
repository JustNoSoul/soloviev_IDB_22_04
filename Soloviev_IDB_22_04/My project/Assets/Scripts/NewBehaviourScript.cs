using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text x;
    public int c;
    public GameObject Testobj;
    bool a = true;

    public void Deactive()
    { 
        if (a == true){
            Testobj.SetActive(false);
            a = false;
        }
        else{
            Testobj.SetActive(true);
            a = true;
    }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CEN");
        c-=1;
        x.text = c.ToString();
    }
}
