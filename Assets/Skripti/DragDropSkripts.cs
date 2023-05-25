using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	
	//Uzglabās norādi uz objektu skriptu
	public Objekti objektuSkripts;
	//Uzglabās norādi uz katra objekta CanvasGroup
	private CanvasGroup kanvasGrupa;

	private RectTransform velkObjRectTransf;


	void Start () {
		kanvasGrupa = GetComponent<CanvasGroup>();
		velkObjRectTransf = GetComponent<RectTransform>();
	}
		

	public void OnBeginDrag(PointerEventData notikums){
		
	}
		
	public void OnDrag(PointerEventData notikums){
	
	}
		

	public void OnEndDrag(PointerEventData notikums){
		
	}
}