using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenChest : MonoBehaviour
{

    public ChestPanelMain ChestPanel;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(1) && !EventSystem.current.IsPointerOverGameObject())
        {
            ChestMain chest = FindChest();
            if (chest) OpenChestPanel(chest);
        }
    }

    ChestMain FindChest()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 3.0f))
        {
            GameObject hitObject = hit.transform.gameObject;

            if (hitObject.GetComponent<ChestMain>()) return hitObject.GetComponent<ChestMain>();
        }

        return null;
    }

    void OpenChestPanel(ChestMain chest)
    {
        ChestPanel.SetChest(chest);
        ChestPanel.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

}
