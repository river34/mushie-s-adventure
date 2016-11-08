using UnityEngine;
using System.Collections;


public class TutorialController : MonoBehaviour {

    public GameObject root;

    GameObject triangle_witch;
    GameObject cube_witch;
    GameObject circle_witch;

    GameObject triange_hand;
    GameObject cube_hand;
    GameObject circle_hand;

    GameObject mushie;

    // Music
    GameObject start;
    GameObject start_2;
    GameObject start_3;
    GameObject start_4;

    bool isReady = false;

    void Start () {
        triangle_witch = GameObject.Find("Tutorial Triangle Witch");
        cube_witch = GameObject.Find("Tutorial Cube Witch");
        circle_witch = GameObject.Find("Tutorial Circle Witch");
        mushie = GameObject.Find("Tutorial Mushie");
        triange_hand = GameObject.Find("Tutorial_Triangle_Hands");
        cube_hand = GameObject.Find("Tutorial_Cube_Hands");
        circle_hand = GameObject.Find("Tutorial_Circle_Hands");

        triangle_witch.SetActive(false);
        cube_witch.SetActive(false);
        circle_witch.SetActive(false);
        mushie.SetActive(false);
        triange_hand.SetActive(false);
        cube_hand.SetActive(false);
        circle_hand.SetActive(false);

        // Music
        start = GameObject.Find("Start");
        start_2 = GameObject.Find("Start_2");
        start_3 = GameObject.Find("Start_3");
        start_4 = GameObject.Find("Start_4");
    }
	
	void Update () {

        if (!isReady)
        {
            start.GetComponent<AudioSource>().Play();
            triangle_witch.SetActive(true);
            cube_witch.SetActive(true);
            circle_witch.SetActive(true);
            StartCoroutine(ShowGesture());
            isReady = true;
        }

	    if (triangle_witch == null && cube_witch != null && !cube_witch.activeSelf)
        {
            start.GetComponent<AudioSource>().Stop();
            start_2.GetComponent<AudioSource>().Play();
            triange_hand.SetActive(false);
            cube_witch.SetActive(true);
            cube_hand.SetActive(true);
        }

        else if (triangle_witch == null && cube_witch == null && circle_witch != null && !circle_witch.activeSelf)
        {
            start_2.GetComponent<AudioSource>().Stop();
            start_3.GetComponent<AudioSource>().Play();
            cube_hand.SetActive(false);
            circle_witch.SetActive(true);
            circle_hand.SetActive(true);
        }

        else if (triangle_witch == null && cube_witch == null && circle_witch == null && mushie != null && !mushie.activeSelf)
        {
            start_3.GetComponent<AudioSource>().Stop();
            start_4.GetComponent<AudioSource>().Play();
            circle_hand.SetActive(false);
            mushie.SetActive(true);
            StartCoroutine(WaitAndPlayMushie());
            StartCoroutine(WaitAndGoToMainScene());
        }
    }

    IEnumerator ShowGesture()
    {
        yield return new WaitForSeconds(20);
        cube_witch.SetActive(false);
        circle_witch.SetActive(false);
        triange_hand.SetActive(true);
    }

    IEnumerator WaitAndPlayMushie()
    {
        yield return new WaitForSeconds(5);
        // mushie.GetComponent<AudioSource>().Play();
    }

    IEnumerator WaitAndGoToMainScene ()
    {
        yield return new WaitForSeconds (5);
        // root.GetComponent<AnimationController>().ChangeToMainCamera();
        root.GetComponent<SceneController>().goToNextScene();
    }
}
