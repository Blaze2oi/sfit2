using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onebyone : MonoBehaviour
{
    public PlayerInventory inventory;
    public GameObject scroll11;
    public GameObject scroll12;
    public GameObject scroll13;
    public GameObject scroll14;
    public GameObject scroll15;

    public GameObject scroll21;
    public GameObject scroll22;
    public GameObject scroll23;
    public GameObject scroll24;
    public GameObject scroll25;

    public GameObject scroll31;
    public GameObject scroll32;
    public GameObject scroll33;
    public GameObject scroll34;
    public GameObject scroll35;
    
    public void Start()
    {
        scroll12.SetActive(false);
        scroll13.SetActive(false);
        scroll14.SetActive(false);
        scroll15.SetActive(false);

        scroll22.SetActive(false);
        scroll23.SetActive(false);
        scroll24.SetActive(false);
        scroll25.SetActive(false);

        scroll32.SetActive(false);
        scroll33.SetActive(false);
        scroll34.SetActive(false);
        scroll35.SetActive(false);
    }

    void Update()
    {
        if (inventory.Scroll == 1)
        {
            scroll12.SetActive(true);
            scroll22.SetActive(true);
            scroll32.SetActive(true);
        }
        if (inventory.Scroll == 2)
        {
            scroll13.SetActive(true);
            scroll23.SetActive(true);
            scroll33.SetActive(true);
        }
        if (inventory.Scroll == 3)
        {
            scroll14.SetActive(true);
            scroll24.SetActive(true);
            scroll34.SetActive(true);
        }
        if (inventory.Scroll == 4)
        {
            scroll15.SetActive(true);
            scroll25.SetActive(true);
            scroll35.SetActive(true);
        }
    }
}
