using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int[] objetosRecogidos;
    public int indicador;
    public float timeOfGame;
    public Text text;
    public Camera playerCamera;

    
    public GameObject carta;
    public int numberOfYears;
    public SaveSO saveDatos;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menú");
        }
    }


    private void Start()
    {
        objetosRecogidos = new int[20];
        indicador = 0;
        timeOfGame = timeOfGame*60;
        StartCoroutine(StartGame());
        
    }


    public int[] getObjetos()
    {
        return objetosRecogidos;
    }

    public void addObject(int localizador)
    {
        objetosRecogidos[indicador] = localizador;
        indicador++;
    }

    IEnumerator StartGame()
    {
        float i = 0;
        while (timeOfGame > 0)
        {
            
            i = i + Time.deltaTime;
            if(i >= 2)
            {
                numberOfYears++;
                i = 0;
                print(numberOfYears);
            }
            timeOfGame = timeOfGame - Time.deltaTime;
            text.text = timeOfGame.ToString();
            yield return null;
        }
        text.text = "0";

        saveDatos.años = numberOfYears;
        saveDatos.elementos = objetosRecogidos;
        SceneManager.LoadScene("Cards");
    }

    public void ChangeTimeOfGame(float a)
    {
        timeOfGame = timeOfGame + a;
        text.text = timeOfGame.ToString();
    }



    
}
