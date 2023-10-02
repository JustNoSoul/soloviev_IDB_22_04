using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
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

}
