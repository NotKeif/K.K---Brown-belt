using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem explosion;
    public ParticleSystem trail;
    void Start()
    {
        explosion.Stop();
        trail.Play();
    }
    void FixedUpdate()
    {
        explosion.transform.position = player.transform.position;
        trail.transform.position = player.transform.position;
    }
    public void GameOver()
    {
        player.SetActive(false);
        Invoke("Died", 2);
        explosion.Play();
        trail.Stop();
    }

    void Reload()
    {
        SceneManager.LoadScene(0);
    }

    void Died()
    {
        SceneManager.LoadScene(1);
    }
}


