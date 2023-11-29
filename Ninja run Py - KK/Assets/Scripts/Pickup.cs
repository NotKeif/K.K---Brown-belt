using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public GameObject door;
    public GameObject coin;

    void Start()
    {
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("touching");
            Destroy(this.gameObject);
            Destroy(coin);

            Destroy(door);

        }

        
       
    }
}
