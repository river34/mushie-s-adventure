using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartPlay : MonoBehaviour {

	void Begin ()
    {
        SceneManager.LoadScene("Main_with_Leap");
    }
}
