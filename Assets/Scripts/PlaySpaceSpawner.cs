using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySpaceSpawner : MonoBehaviour
{
    public GameObject Points;
    public Transform PointA, PointB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        //chooses a random position between the two points to spawn Object
        Vector3 pos = Vector3.zero;
        pos.x = Random.Range(PointA.transform.position.x, PointB.transform.position.x);
        pos.y = 0;
        pos.z = Random.Range(PointA.transform.position.z, PointB.transform.position.z);

        //Spawns Points
        Instantiate(Points, pos, Quaternion.identity);
    }
}
