using UnityEngine;
using System.Collections;

public class ShapeApear : MonoBehaviour {

    public float speed = 4f;

    public float initial_x = 0f;

    public float initial_y = 0f;

    public float initial_z = 0f;

    public float final_x = 1f;

    public float final_y = 1f;

    public float final_z = 1f;

    void Start ()
    {
        transform.localScale = new Vector3 (initial_x, initial_y, initial_z);
    }

	void Update ()
    {
	    if (transform.localScale.x < final_x && transform.localScale.y < final_y && transform.localScale.z < final_z)
        {
            transform.localScale += new Vector3 (speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
        }
	}
}
