using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winMode : MonoBehaviour
{

    

    public void OnTriggerEnter(Collider other)
    {
       
        if(other.gameObject.tag=="endZone")
        {
            Debug.Log("Entered Delivery Zone");

        }
        
    }


    


}
