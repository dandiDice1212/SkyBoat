using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDrift : MonoBehaviour
{
    public Vector3 driftDirection = new Vector3(1f, 0f, 0f);
    public float speed = 1f;

    void Update()
    {
        transform.position += driftDirection * speed * Time.deltaTime;
    }
}
