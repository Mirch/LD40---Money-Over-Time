using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByFall : MonoBehaviour
{

    public GameObject GameController;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            GameController.GetComponent<GameController>().GameOver();
        }
    }

}
