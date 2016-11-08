using UnityEngine;
using System.Collections;

public class ShapeMove : MonoBehaviour {

    public float speed = 3.0f;

	void Update () {
        Vector3 movement = new Vector3(0, 0, 1f);
        transform.position += movement * speed * Time.deltaTime;
    }
}
