using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public float pointsValue;
    private GameManager gameManager;

    public void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            gameManager.score += pointsValue;
            Destroy(gameObject);
        }
    }
}
