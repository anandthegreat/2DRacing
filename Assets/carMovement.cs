using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carMovement : MonoBehaviour {
 
   
	public float carSpeed;
	Vector3 pos;
    uiManager obj;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	}

	
	// Update is called once per frame
	void Update () {
		pos.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime * 2;

		if(pos.x>-2.130326 && pos.x<2.228868){
			transform.position = pos;
		}
	}

	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Enemy Car") {
            
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			Destroy (gameObject);
            obj.GameOver();
		
		}
	}
}
