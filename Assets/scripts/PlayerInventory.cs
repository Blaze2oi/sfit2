using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    SetSelect SetSelect;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject scrolls1;
    public GameObject scrolls2;
    public GameObject scrolls3;

    public int Scroll;
    public GameObject panel11;
    public GameObject panel12;
    public GameObject panel13;
    public GameObject panel14;
    public GameObject panel15;

    public GameObject panel21;
    public GameObject panel22;
    public GameObject panel23;  
    public GameObject panel24;
    public GameObject panel25;

    public GameObject panel31;
    public GameObject panel32;
    public GameObject panel33;
    public GameObject panel34;
    public GameObject panel35;

    public void Start()
    {
        if (SetSelect.set == 1)
        {
            canvas1.SetActive(true);
            canvas2.SetActive(false);
            canvas3.SetActive(false);
            scrolls1.SetActive(true);
            scrolls2.SetActive(false);
            scrolls3.SetActive(false);
        }
        if (SetSelect.set == 2)
        {
            canvas1.SetActive(false);
            canvas2.SetActive(true);
            canvas3.SetActive(false);
            scrolls1.SetActive(false);
            scrolls2.SetActive(true);
            scrolls3.SetActive(false);
        }
        if (SetSelect.set == 3)
        {
            canvas1.SetActive(false);
            canvas2.SetActive(false);
            canvas3.SetActive(true);
            scrolls1.SetActive(false);
            scrolls2.SetActive(false);
            scrolls3.SetActive(true);
        }
    }

    public void ScrollCollected()
    {
        Scroll++;
        if (Scroll == 1)
        {
            panel11.SetActive(true);    
            panel21.SetActive(true);    
            panel31.SetActive(true);
        }
        if (Scroll == 2)
        {
            panel12.SetActive(true);
            panel22.SetActive(true);
            panel32.SetActive(true);
        }
        if (Scroll == 3)
        {
            panel13.SetActive(true);
            panel23.SetActive(true);
            panel33.SetActive(true);
        }
        if (Scroll == 4)
        {
            panel14.SetActive(true);
            panel24.SetActive(true);
            panel34.SetActive(true);
        }
        if (Scroll == 5)
        {
            panel15.SetActive(true);
            panel25.SetActive(true);
            panel35.SetActive(true);
        }
    }
    public void FixedUpdate()
    {
        bool close = Input.GetKey(KeyCode.N);
        bool c1 = Input.GetKey(KeyCode.Alpha1);
        bool c2 = Input.GetKey(KeyCode.Alpha2);
        bool c3 = Input.GetKey(KeyCode.Alpha3);
        bool c4 = Input.GetKey(KeyCode.Alpha4);
        bool c5 = Input.GetKey(KeyCode.Alpha5);

        if (close)
        {
            panel11.SetActive(false);
            panel12.SetActive(false);
            panel13.SetActive(false);
            panel14.SetActive(false);
            panel15.SetActive(false);

            panel21.SetActive(false);
            panel22.SetActive(false);
            panel23.SetActive(false);
            panel24.SetActive(false);
            panel25.SetActive(false);

            panel31.SetActive(false);
            panel32.SetActive(false);
            panel33.SetActive(false);
            panel34.SetActive(false);
            panel35.SetActive(false);
        }
        if (c1 && Scroll>=1)
        {
            panel11.SetActive(true);
            panel21.SetActive(true);
            panel31.SetActive(true);
        }
        if (c2 && Scroll >= 2)
        {
            panel12.SetActive(true);
            panel22.SetActive(true);
            panel32.SetActive(true);
        }
        if (c3 && Scroll >= 3)
        {
            panel13.SetActive(true);
            panel23.SetActive(true);
            panel33.SetActive(true);
        }
        if (c4 && Scroll >= 4)
        {
            panel14.SetActive(true);
            panel24.SetActive(true);
            panel34.SetActive(true);
        }
        if (c5 && Scroll >= 5)
        {
            panel15.SetActive(true);
            panel25.SetActive(true);
            panel35.SetActive(true);
        }
    }
}
