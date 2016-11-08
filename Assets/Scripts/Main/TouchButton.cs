using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TouchButton : MonoBehaviour {

	void onTriggerEnter (Collider other)
    {
        if (other.CompareTag ("Button"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Main_with_Leap");
        }
    }
}
