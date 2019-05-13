using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private void Start()
    {
        
        
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.Self);
    }

    //IEnumerator Rotate()
    //{
    //    float elapsedTime = 0;
    //    float animationTime = 4f;

    //    while (elapsedTime < animationTime)
    //    {

    //        transform.rotation = new Quaternion(transform.rotation.x,transform.rotation.y + 45,transform.rotation.z, transform.rotation.w);

    //        elapsedTime += Time.deltaTime;
    //        yield return 0;
    //    }

    //}
}
