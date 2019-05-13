using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public enum Axes { MouseX, MouseY }
    public Axes axis;

    public float sensibility = 1;

    public float minimum;
    public float maximum;

    Quaternion originalRotation;
    public float rotation = 0;
    void Start()
    {
        originalRotation = transform.localRotation;
    }
    // Update is called once per frame
    void Update()
    {

        if (axis == Axes.MouseX)
        {
            rotation += Input.GetAxis("Mouse X") * sensibility;

            rotation = ClampAngle(rotation, minimum, maximum);
            Quaternion rot = Quaternion.AngleAxis(rotation, Vector3.up);
            transform.localRotation = originalRotation * rot;
        }

        if (axis == Axes.MouseY)
        {
            rotation += Input.GetAxis("Mouse Y") * sensibility;

            rotation = ClampAngle(rotation, minimum, maximum);
            Quaternion rot = Quaternion.AngleAxis(-rotation, Vector3.right);
            transform.localRotation = originalRotation * rot;
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        angle = angle % 360;
        if ((angle >= -360F) && (angle <= 360F))
        {
            if (angle < -360F)
            {
                angle += 360F;
            }
            if (angle > 360F)
            {
                angle -= 360F;
            }
        }
        return Mathf.Clamp(angle, min, max);
    }
}
