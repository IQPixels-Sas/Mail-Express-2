using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour 
{
	public GameObject CarMain_tr;
	private Vector3 offSet_Vec;
	void Start()
	{
		offSet_Vec = transform.position - CarMain_tr.transform.position;
	}
	void LateUpdate()
	{
		transform.position = CarMain_tr.transform.position + offSet_Vec;
	}
}
