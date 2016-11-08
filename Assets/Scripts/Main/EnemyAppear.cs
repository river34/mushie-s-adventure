using UnityEngine;
using System.Collections;

public class EnemyAppear : MonoBehaviour
{

    public GameObject boss;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Mushie"))
        {
            StartCoroutine("Appear");
        }
    }

    IEnumerator Appear()
    {
        for (int i = 0; i < 35; i++)
        {
            boss.transform.Translate (0.0f, 0.5f, 0.0f);
            yield return new WaitForEndOfFrame();
        }
        /*
        for (float f = 0f; f <= 10; f += 1.2f)
        {
            transform.Translate(0, 1f, 0);
            yield return null;
        }
        */
    }
}

