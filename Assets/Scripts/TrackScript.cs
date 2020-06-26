// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class TrackScript : MonoBehaviour
// {

//     private float fallDelay = 5;

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     void OnTriggerExit(Collider other)
//     {
//         if (other.tag == "Player")
//         {
//             TrackManager.Instance.SpawnTrack();
//             StartCoroutine(FallDown());
//             // Debug.Log("Spawn track");
//         }
//     }

//     IEnumerator FallDown()
//     {
//         yield return new WaitForSeconds(fallDelay);
//         GetComponent<Rigidbody>().isKinematic = false;
//     }

// }
