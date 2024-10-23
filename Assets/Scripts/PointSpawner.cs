using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    public GameObject points;
    public Transform pointA, pointB;
    public float timer;
    public float resetTime;

    // Start is called before the first frame update
    void Start()
    {
        timer = resetTime;

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Spawn();
            if (resetTime > .14f)
            {
                resetTime -= .01f;
            }
            timer = resetTime;
        }
    }


    void Spawn()
    {
        Vector3 pos = Vector3.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f));
        pos.x = Random.Range(pointA.position.x, pointB.position.x);
        pos.y = Random.Range(pointA.position.y, pointB.position.y);
        Instantiate(points, pos, Quaternion.identity);
    }
}
