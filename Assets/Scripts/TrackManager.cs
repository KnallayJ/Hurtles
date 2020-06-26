using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{

    // public GameObject straightTrackPrefab;

    // public GameObject spindleObstacleTrackPrefab;

    // public GameObject rightTrackPrefab;

    public GameObject[] trackPrefabs;

    public GameObject currentTrack;

    private static TrackManager instance;

    // private Stack<GameObject> straightTracks = new Stack<GameObject>();

    public static TrackManager Instance 
    {
        get 
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<TrackManager>();
            }
            return instance; 
        }
    }


    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 500; i++)
        {
            SpawnTrack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void CreateTrack(int amount)
    // {
    //     for (int i = 0; i < amount; i++)
    //     {
    //         straightTracks.Push(Instantiate);
    //     }
    // }

    public void SpawnTrack()
    {
        int randomIndex = Random.Range(0, 6);

        currentTrack = (GameObject)Instantiate(trackPrefabs[randomIndex], currentTrack.transform.GetChild(0).position, Quaternion.identity);
    }

}
