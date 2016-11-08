using UnityEngine;
using System.Collections;

public class MoveMushie : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.MoveBy(gameObject, iTween.Hash("y", 0.05, "easeType", "EaseInCirc", "loopType", "pingpong", "delay", .01));
        iTween.RotateBy(gameObject, iTween.Hash("y", 1, "easeType", "EaseInquad", "loopType", "loop", "delay", 5));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
