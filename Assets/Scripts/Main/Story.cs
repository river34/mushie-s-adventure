using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour {

    public GameObject story_1;

    public GameObject story_2;

    void Start () {
        story_1.SetActive(true);

        StartCoroutine(Next());
    }

    IEnumerator Next()
    {
        yield return new WaitForSeconds(5);

        story_1.SetActive(false);
        story_2.SetActive(true);

        StartCoroutine(NextScene());
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Tutorial");
    }
}
