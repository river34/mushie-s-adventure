using UnityEngine;
using System.Collections;

public class MoveWithCamera : MonoBehaviour {

    public GameObject camera;

    Vector3 offset;

    void Start ()
    {
        offset = transform.position - camera.transform.position;
    }

	void Update () {
        transform.position = camera.transform.position + offset;
    }
}
