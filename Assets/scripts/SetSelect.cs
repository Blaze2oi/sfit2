using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetSelect : MonoBehaviour
{
    public static int set = 0;
    public void Onclick1()
    {
        set = 1;
        SceneManager.LoadScene(1);
    }
    public void Onclick2()
    {
        set = 2;
        SceneManager.LoadScene(1);
    }
    public void Onclick3()
    {
        set = 3;
        SceneManager.LoadScene(1);
    }
}
