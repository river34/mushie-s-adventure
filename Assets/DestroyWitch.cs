using UnityEngine;
using System.Collections;

public class DestroyWitch : MonoBehaviour
{

    void onTriggerEnter(Collider other)
    {
        if (CompareTag("Triangle Enemy") && other.CompareTag("Triangle"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if (CompareTag("Cube Enemy") && other.CompareTag("Cube"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if (CompareTag("Circle Enemy") && other.CompareTag("Circle"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}