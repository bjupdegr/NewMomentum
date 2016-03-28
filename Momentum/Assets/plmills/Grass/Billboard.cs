using UnityEngine;
using System.Collections;

using UnityEngine;


public class Billboard : MonoBehaviour
{
	public Camera c;

	void Update() 
	{
		//If there is no camera in the scene then this will prevent NullReferenceException
		try{
			//Points grass sprite in direction of the main camera
			transform.LookAt(Camera.main.transform.position, Vector3.up);
		}
		catch(System.Exception e){

		}
			
	}
}
