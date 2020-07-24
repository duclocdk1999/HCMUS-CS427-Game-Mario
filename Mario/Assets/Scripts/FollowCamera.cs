using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    private Transform cameraTransform;
	// Use this for initialization
	void Start () {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update () {
        Vector3 temp = transform.position;
        temp.x = cameraTransform.position.x;
        transform.position = temp;
	}
}
