using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelButtons : MonoBehaviour
{

    [SerializeField] GameObject inventory;
    [SerializeField] GameObject minning;
    [SerializeField] GameObject shop;

    public void Inventory()
    {
        inventory.SetActive(true);
        minning.SetActive(false);
        shop.SetActive(false);
    }

    public void Minning()
    {
        minning.SetActive(true);
        inventory.SetActive(false);
        shop.SetActive(false);
    }

    public void Shop()
    {
        shop.SetActive(true);
        minning.SetActive(false);
        inventory.SetActive(false);
    }

}

