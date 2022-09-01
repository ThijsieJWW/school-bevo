using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public Transform target;
    public float TimeBetween = 0.2f;

    public Vector3 offset;
    private void LateUpdate()
    {
        Vector3 desirePoint = target.position + offset;
        Vector3 smoothed_position = Vector3.Lerp(transform.position, desirePoint, TimeBetween);
        transform.position = smoothed_position;
    }
}
