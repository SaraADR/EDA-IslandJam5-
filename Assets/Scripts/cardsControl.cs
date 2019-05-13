using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardsControl : MonoBehaviour
{
    public List<CardsSO> listaOfObjects;


    public void showCard(int i)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = listaOfObjects[i].imagen;
        
    }

 
}
