using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoBase : MonoBehaviour
{
    public ObjectSO scriptable;

    private void Start()
    {
        scriptable = gameObject.GetComponent<ObjectSO>();
    }
}
