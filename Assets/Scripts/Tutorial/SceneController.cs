using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Leap.Unity;

public class SceneController : MonoBehaviour
{

    public void goToNextScene()
    {
        if (SceneManager.GetActiveScene().name == "Logo")
        {
            SceneManager.LoadScene("Opening");
        }
        else if (SceneManager.GetActiveScene().name == "Start")
        {
            SceneManager.LoadScene("Opening");
        }
        else if (SceneManager.GetActiveScene().name == "Opening")
        {
            SceneManager.LoadScene("Tutorial");
        }
        else if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            SceneManager.LoadScene("Main_with_Leap");
        }
        else if (SceneManager.GetActiveScene().name == "Main_with_Leap")
        {
            SceneManager.LoadScene("Credits");
        }
        else if (SceneManager.GetActiveScene().name == "Credits")
        {
            SceneManager.LoadScene("Start");
        }

        // print(SceneManager.GetActiveScene().name);
    }

    public void GoToDeathScene()
    {
        GetComponent<AnimationController>().GoToDeathScene();
    }

    public void GoToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}

/*
 * 1. The weakness of those three witches are the shapes on their hats.
 * 2. So I need to create shape magic to defeat them.
 * 3. Ahh... it has been so long since I used my magic.
 * 4. I need to practice.
 * 5. I need to put two hands in front of me ...
 * 6. ... and make a triangle with my index and thumb fingers of both hands to create triangle magic.  
 * 7. There it is.
 * 8. Now it is time to practice square magic.
 * 9. I need to twist a hand and make a square with index and thumb fingers of both hands.
 * 10. That's right.
 * 11. The last one is circle magic.
 * 12. I need to make two circles with index and thumb fingers of each hand.
 * 13. Now I have restored my power.
 * 14. I am ready to help Mushie on his journey. 
 * */
