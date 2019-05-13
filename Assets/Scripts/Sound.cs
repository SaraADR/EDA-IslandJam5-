using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {  
        sound.SetActive(false);
    }

    public void pressButton()
    {
        if(AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            sound.SetActive(true);
        }
        else
        {
            AudioListener.volume = 1;
            sound.SetActive(false);
        }
    }
}
