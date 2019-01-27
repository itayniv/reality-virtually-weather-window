using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_script : MonoBehaviour {


    public GameObject playanimation;
    float timeLeft = 10.0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (timeLeft > 0){
            
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {

                playanimation =  GameObject.FindGameObjectWithTag("playAnimation");
                playanimation.SetActive(false);
                Destroy(playanimation, 0.2f);

            }
            
        }
       
		
	}



  



}
