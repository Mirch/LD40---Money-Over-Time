using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PickUp : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            GetBall();
        }

    }

    void GetBall()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 3.0f))
        {
            bool ball = hit.transform.gameObject.CompareTag("Coin");
            if (ball)
            {
                GetComponent<PlayerInventory>().OccupiedSlots++;

                hit.transform.gameObject.GetComponent<MeshRenderer>().enabled = false;
                hit.transform.gameObject.GetComponent<CapsuleCollider>().enabled = false;


                hit.transform.gameObject.GetComponent<AudioSource>().Play();
                
                Destroy(hit.transform.gameObject, 1f);
            }
        }
    }
}