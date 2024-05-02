using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Targe : MonoBehaviour
{
    public void start_game ()
    {
        SceneManager.LoadScene(1);
    }

    public void menu_game ()
    {
        SceneManager.LoadScene(0);
    }

    public void Credit_game ()
    {
        SceneManager.LoadScene(2);
    }

}
