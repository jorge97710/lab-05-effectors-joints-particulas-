using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

	float time =0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		time += Time.deltaTime;
		
		if (time > 5){
			
		if (time > 10){
			gameObject.SetActive(true);	

			
		}else{
			
			gameObject.SetActive(false);	
			
		}
		
		}
			//	gameObject.SetActive(true);	
			

		
		
				
			
		
	}
}
