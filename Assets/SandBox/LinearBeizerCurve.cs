using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearBeizerCurve : MonoBehaviour {

	//	"Linear Interpollllation Formula"
	//  "CurrentPoint = P0 + t(P1 – P0)  ,  0 < t < 1"
	//	where "CurrentPoint" is the current value
	//	where "P0" is the first vector
	//	where "P1" is the second vector
	//	where "t" is value (0 to 1) 



	[Range(0,1)]
	public float t=0;
	public Vector3 P0;
	public Vector3 P1;
	public Vector3 CurrentPoint;

	public GameObject spriteIndicator;

	public GameObject gobjP0,gobjP1,gobjCurrentPoint;

	void Start()
	{
		P0=gobjP0.transform.position;
		P1=gobjP1.transform.position;

		gobjCurrentPoint=Instantiate(spriteIndicator,CurrentPoint,Quaternion.identity);
		gobjCurrentPoint.transform.SetParent(gameObject.transform);
	}


	void Update () 
	{
		CurrentPoint=P0+t*(P1-P0);	

		gobjCurrentPoint.transform.position=CurrentPoint;	
	}
}
