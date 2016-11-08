using UnityEngine;
using System.Collections;

public class ReachEndPoint : MonoBehaviour {

    public GameObject mushie;

    public Animator ac;

    public GameObject root;

    float speed = 6;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag ("End Point"))
        {
            ac.SetTrigger("Success");
            // StartCoroutine(MoveForward());
            // wait for 5 seconds
            // GoToSuccessScene
            StartCoroutine(WaitAndGoToSuccessScene());
        }
    }

    IEnumerator MoveForward()
    {
        for (float f = 0f; f <= 1; f += 0.1f)
        {
            transform.position += new Vector3 (0, 0, f * speed * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator WaitAndGoToSuccessScene ()
    {
        yield return new WaitForSeconds(2);
        root.GetComponent <AnimationController> ().GoToSuccessScene();
    }
}
