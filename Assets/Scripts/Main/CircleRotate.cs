using UnityEngine;
using System.Collections;

public class CircleRotate : MonoBehaviour
{

    public float speed = 3.0f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 30) * speed * Time.deltaTime);
    }
}
