using UnityEngine;
using System.Collections;

public class MoveTowardsEnemy : MonoBehaviour
{
	float range = 20f;

	GameObject[] enemies;

    float speed;

	void Start()
	{
        // speed = GetComponent<MoveForward>().speed + 4f;
	}
    
    void Update()
    {
        if (gameObject.CompareTag("Cube"))
        {
            enemies = GameObject.FindGameObjectsWithTag("Cube Enemy");
        }
        else if (gameObject.CompareTag("Triangle"))
        {
            enemies = GameObject.FindGameObjectsWithTag("Triangle Enemy");
        }
        else if (gameObject.CompareTag("Circle"))
        {
            enemies = GameObject.FindGameObjectsWithTag("Circle Enemy");
        }

        int min_i = -1;

        float min_z = range + transform.position.z;

        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i].transform.position.z < min_z && enemies[i].transform.position.z > transform.position.z)
            {
                min_z = enemies[i].transform.position.z;
                min_i = i;
            }
        }

        if (min_i != -1)
        {
            GameObject closestEnemy = enemies[min_i];

            // GetComponent<MoveForward>().target = closestEnemy.transform;

            // GetComponent<MoveForward>().speed = speed;

            // GetComponent<MoveForward>().enabled = true;
        }
        else
        {
            // GetComponent<MoveForward>().target = null;

            // GetComponent<MoveForward>().speed = 0;

            // GetComponent<MoveForward>().enabled = false;

            transform.position += new Vector3(0f, 1f * speed * Time.deltaTime, 2f * speed * Time.deltaTime);

            Destroy(this.gameObject, 10);
        }

        /*
        if (min_i == -1)
        {
            transform.position += new Vector3 (0f, 1f * speed * Time.deltaTime, 1f * speed * Time.deltaTime);
            Destroy(this.gameObject, 3);
        }

        Destroy(this.gameObject, 10);
        */
    }
}
