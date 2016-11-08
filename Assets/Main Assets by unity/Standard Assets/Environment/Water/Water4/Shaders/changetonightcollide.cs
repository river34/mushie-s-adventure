using UnityEngine;
using System.Collections;

public class changetonightcollide : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "changetonight")
        {

        }
    }
}