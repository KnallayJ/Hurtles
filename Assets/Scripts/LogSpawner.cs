using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    LogPooler logPooler;

    private void Start()
    {
        logPooler=LogPooler.Instance;
    }

    void FixedUpdate ()
    {
        logPooler.SpawnFromPool("Log", transform.position, Quaternion.identity);
    }
   
}
