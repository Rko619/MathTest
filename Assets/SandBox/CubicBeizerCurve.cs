using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicBeizerCurve : MonoBehaviour {


	//	"Cubic Beizer Curve Formula"
	//	B(t) = (1-t)^3*P0 + 3(1-t)^2t*P1 + 3(1-t)t^2*P2 + t^3*P3 , 0 < t < 1
	//	It can draw curve with three or more points
	//	where "B(t) is the Cubic Beizer Curve Function
	//	where "P0" is the point one
	//	where "P1" is the point two
	//	where "P2" is the poin three
	// 	where "t" is the range(0-1)


	[Range(0,1)]
	public float t;
	public Vector3 P0;
	public Vector3 P1;
	public Vector3 P2;
	public Vector3 P3;

	public Vector3 CurrentPoint;

	public GameObject spriteIndicator;


	public GameObject gobjP0,gobjP1,gobjP2,gobjP3,gobjCurrentPoint;


	void Start()
	{
		P0=gobjP0.transform.position;
		P1=gobjP1.transform.position;
		P2=gobjP2.transform.position;
		P3=gobjP3.transform.position;

		gobjCurrentPoint=Instantiate(spriteIndicator,CurrentPoint,Quaternion.identity);
		gobjCurrentPoint.transform.SetParent(gameObject.transform);
	}
	void Update () 
	{
		//B(t) = (1-t)^3*P0 + 3(1-t)^2t*P1 + 3(1-t)t^2*P2 + t^3*P3
		CurrentPoint=Mathf.Pow((1-t), 3)*P0+ 3*Mathf.Pow((1-t), 2)*t*P1+ 3*(1-t)*Mathf.Pow(t, 2)*P2+ Mathf.Pow(t, 3)*P3;
		
		gobjCurrentPoint.transform.position=CurrentPoint;
	}
}
