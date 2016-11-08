using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Gotomainscene : MonoBehaviour {

	public void onClick()
    {
        
        SceneManager.LoadScene("Main_with_Leap");
    }
}
