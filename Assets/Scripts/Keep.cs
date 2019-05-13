using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Keep : MonoBehaviour
{

    public ObjectSO objeto;
    public GameObject manager;

    public GameObject player;
    public GameObject audio;
    
   

    private void OnTriggerEnter(Collider other)
    {
        audio.GetComponent<AudioSource>().Play();
        if (objeto.timeOfGame != 0)
        {
            manager.GetComponent<GameManager>().ChangeTimeOfGame(objeto.timeOfGame);
        }
        if (objeto.speedOfPlayer != 0)
        {
            player.GetComponent<Movement>().changeVelocity(objeto.speedOfPlayer);
        }
        if (objeto.InvControls == true)
        {
            player.GetComponent<Movement>().invertControls();
        }
        if (objeto.ChangeControls == true)
        {
            player.GetComponent<Movement>().FlechaControl();
        }

        if(gameObject.name == "Femenino" && SceneManager.GetActiveScene().name != "Fase 1")
        {
            SceneManager.LoadScene("Fase 1");
        }
        if (gameObject.name == "Masculino" && SceneManager.GetActiveScene().name != "Fase 1")
        {
            SceneManager.LoadScene("Fase 1" );
        }
        manager.GetComponent<GameManager>().addObject(objeto.identificador);
        Destroy(gameObject);

    }
}
