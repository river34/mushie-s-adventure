using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {
    
	void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag ("Triangle Enemy") && this.CompareTag ("Triangle"))
        {
            Destroy (other.gameObject, 2);
            Destroy (this.gameObject);
        }
        else if (other.CompareTag ("Cube Enemy") && this.CompareTag("Cube"))
        {
            Destroy(other.gameObject, 2);
            Destroy(this.gameObject);
        }
        else if (other.CompareTag("Circle Enemy") && this.CompareTag("Circle"))
        {
            Destroy(other.gameObject, 2);
            Destroy(this.gameObject);
        }

        if (other.CompareTag ("Disappear Effect"))
        {
            other.GetComponent<StopEmission>().StartEmission();
        }
    }
}
