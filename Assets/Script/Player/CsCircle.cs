using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCircle : MonoBehaviour {

    int moveSpeed = 20;
    int rotSpeed = 120;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float amtMove = moveSpeed * Time.smoothDeltaTime;
        float amtRot = rotSpeed * Time.smoothDeltaTime;
        float keyMove = Input.GetAxis("Vertical");
        float keyRot = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, 0, 1) * amtMove * keyMove);
        transform.Rotate(new Vector3(0, 1, 0) * amtRot * keyRot);

    }
}
