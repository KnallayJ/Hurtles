using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMovement : MonoBehaviour, IPooledLog
{
    
    public float sideForce=1000f;
    // Start is called before the first frame update
    public void OnLogSpawn()
    {
        Vector3 force =new Vector3(sideForce,0,0);

        GetComponent<Rigidbody>().velocity=force;
    }

    // Update is called once per frame
  
}