using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fix_position : MonoBehaviour {

    public GameObject boxPosition;
    private Vector3 CurrPosition;
    private GameObject generatePlanesObject;


	// Use this for initialization
	void Start () {

        generatePlanesObject = GameObject.FindWithTag("debugPlanes");

        Debug.Log(boxPosition.transform.position + "box Position");
        CurrPosition = boxPosition.transform.position;
        Debug.Log(CurrPosition + "curr Position");



	}
	
	// Update is called once per frame
	void Update () {


        if ( CurrPosition != boxPosition.transform.position){

            generatePlanesObject.SetActive(false);
            Destroy(generatePlanesObject, 0.5f);
            
        }
		
	}
}
