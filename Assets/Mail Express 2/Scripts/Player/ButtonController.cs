using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
	public bool pulsed_bo;

	public void OnPointerDown(PointerEventData eventData)
	{
		pulsed_bo = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		pulsed_bo = false;
	}
}
