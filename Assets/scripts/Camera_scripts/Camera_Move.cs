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
        transform.position = new Vector3(target.position.x, 0, 0) + offset;
    }
}
