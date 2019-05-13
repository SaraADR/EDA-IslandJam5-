using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    

    public void change(int i)
    {
        if(i == 0)
        {
            SceneManager.LoadScene("Game");
        }

        if(i == 1)
        {
            SceneManager.LoadScene("Cards");
        }
        if(i == 2)
        {
            SceneManager.LoadScene("Menú");
        }
        if (i == 3)
        {
            SceneManager.LoadScene("Fase 1");
        }
        if (i == 4)
        {
            SceneManager.LoadScene("IslandJamV");
        }
        if (i == 5)
        {
            SceneManager.LoadScene("Controls");
        }


    }
}
