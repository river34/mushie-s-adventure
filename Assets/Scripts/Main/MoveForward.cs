using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour
{
    public Transform target;

    public float speed;

    void Update()
    {
        if (target)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}