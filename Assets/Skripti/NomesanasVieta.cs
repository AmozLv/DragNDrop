using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler  {
	
	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm;
	public Objekti objektuSkripts;
	
	public void OnDrop(PointerEventData eventData){
		if (eventData.pointerDrag != null) {
			if (eventData.pointerDrag.tag.Equals (tag)) {
				
				vietasZrot = GetComponent<RectTransform> ().transform.eulerAngles.z;
				velkObjZrot = eventData.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;

				rotacijasStarpiba = Mathf.Abs(velkObjZrot - vietasZrot);

				vietasIzm = eventData.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;

				xIzmeruStarp = Mathf.Abs (velkObjIzm.x - vietasIzm.x );
				yIzmeruStarp = Mathf.Abs (velkObjIzm.y - vietasIzm.y );

				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
				    && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {

					objektuSkripts.vaiIstajaVieta = true;

					eventData.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					switch (eventData.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [1]);
						break;

					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [2]);
						break;

					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [3]);
						break;
						//Pārbauda tagu un atskaņo atbilstošo skaņas efektu
					case "B2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						break;

					case "Cements":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [8]);
						break;

					case "e46":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						break;
					case "e61":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						break;

					case "Eskavators":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [7]);
						break;

					case "Policija":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [5]);
						break;
					case "Traktors1":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [6]);
						break;

					case "Traktors5":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [9]);
						break;

					case "Ugunsdzeseji":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [10]);
						break;
					}
				}
				} else {
					objektuSkripts.vaiIstajaVieta = false;
					objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [0]);
					switch (eventData.pointerDrag.tag) {
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.atkrMKoord;
					break; 

				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.atraMKoord;
					break;

				case "Skola":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussMKoord;
					break;
					//Ja objekts nomests nepareizajā laukā
				case "B2":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.b2MKoord;
					break; 

				case "Cements":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.cemtMKoord;
					break;

				case "e46":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.e46MKoord;
					break;
				case "e61":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.e61MKoord;
					break; 

				case "Eskavators":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.eskavMKoord;
					break;

				case "Policija":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.policijaMKoord;
					break;
				case "Traktors1":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.dzeltTrakMKoord;
					break; 

				case "Traktors5":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.zalTrakMKoord;
					break;

				case "Ugunsdzeseji":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.ugunsMKoord;
					break;

			
					}
				}
			}
		}
	}
 
