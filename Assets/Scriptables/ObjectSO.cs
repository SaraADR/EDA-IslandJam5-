using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ObjectSO : ScriptableObject
{
    public string name;
    public int identificador;
    public float timeOfGame;
    public float speedOfPlayer;
    public bool InvControls;
    public bool ChangeControls;
}
