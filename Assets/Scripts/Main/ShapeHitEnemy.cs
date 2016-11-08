using UnityEngine;
using System.Collections;

public class ShapeHitEnemy : MonoBehaviour
{

	void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag ("Triangle Enemy") && CompareTag ("Triangle"))
        {
            Destroy (gameObject);
            Destroy (other.gameObject);
        }
        if (other.CompareTag("Cube Enemy") && CompareTag("Cube"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Circle Enemy") && CompareTag("Circle"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
