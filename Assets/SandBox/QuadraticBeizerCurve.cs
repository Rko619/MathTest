using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadraticBeizerCurve : MonoBehaviour {


	//	"Quadratic Beizer Curve Formula"
	//	B(t) = Square((1-t))*P0 + 2(1-t)tP1 + Square(t)*P2 , 0 < t < 1
	//	It can draw curve with three or more points
	//	where "B(t) is the Quadratic Beizer Curve Function
	//	where "P0" is the point one
	//	where "P1" is the point two
	//	where "P2" is the poin three
	// 	where "t" is the range(0-1)


	[Range(0,1)]
	public float t;
	public Vector3 P0;
	public Vector3 P1;
	public Vector3 P2;

	public Vector3 CurrentPoint;

	public GameObject spriteIndicator;


	public GameObject gobjP0,gobjP1,gobjP2,gobjCurrentPoint;


	void Start()
	{
		P0=gobjP0.transform.position;
		P1=gobjP1.transform.position;
		P2=gobjP2.transform.position;

		gobjCurrentPoint=Instantiate(spriteIndicator,CurrentPoint,Quaternion.identity);
		gobjCurrentPoint.transform.SetParent(gameObject.transform);
	}
	void Update () 
	{
		//B(t) = Square((1-t))*P0 + 2(1-t)tP1 + Square(t)*P2
		CurrentPoint=Mathf.Pow((1-t),2f)*P0+2*(1-t)*t*P1+Mathf.Pow(t,2)*P2;
		
		gobjCurrentPoint.transform.position=CurrentPoint;
	}
}
