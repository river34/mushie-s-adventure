using UnityEngine;
using System.Collections;

public class ShapeDisapear : MonoBehaviour {

	public int lifetime = 5;

	void Update ()
	{
		StartCoroutine (EndLife (lifetime));
	}

	IEnumerator EndLife (int seconds)
	{
		yield return new WaitForSeconds (seconds);
		Destroy (gameObject);
	}
}
