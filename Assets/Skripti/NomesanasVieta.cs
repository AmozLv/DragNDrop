using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NomesanasVieta : MonoBehaviour, IDropHandler  {
	
	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm;
	public Objekti objektuSkripts;


	// Use this for initialization
	void Start () {
		//izslēdz  zvaigznes Programmas sākumā
		objektuSkripts.zvaigzne1.SetActive(false);
		objektuSkripts.zvaigzne2.SetActive(false);
		objektuSkripts.zvaigzne3.SetActive(false);
	} 

	// Update is called once per frame
	void Update () {

		//Pārbauda speles sekundžu skaitu un izvēlas attiexīgi zvaigžņu daudzumu
		if (objektuSkripts.laiks <= 100)
		{
			objektuSkripts.zvaigzne1.SetActive(true);
			objektuSkripts.zvaigzne2.SetActive(true);
			objektuSkripts.zvaigzne3.SetActive(true);
		}
		else if (objektuSkripts.laiks > 100 && objektuSkripts.laiks <= 150)
		{
			objektuSkripts.zvaigzne1.SetActive(true);
			objektuSkripts.zvaigzne2.SetActive(true);
			objektuSkripts.zvaigzne3.SetActive(false);
		}
		else if (objektuSkripts.laiks > 200)
		{
			objektuSkripts.zvaigzne1.SetActive(true);
			objektuSkripts.zvaigzne2.SetActive(false);
			objektuSkripts.zvaigzne3.SetActive(false);
		}

	}
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
						objektuSkripts.punkti++;
						Debug.Log (objektuSkripts.punkti);
						break;

					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [2]);
						objektuSkripts.punkti++;
						Debug.Log (objektuSkripts.punkti);

						break;

					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [3]);
						objektuSkripts.punkti++;
						Debug.Log (objektuSkripts.punkti);
					
						break;
						//Pārbauda tagu un atskaņo atbilstošo skaņas efektu
					case "B2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						objektuSkripts.punkti++;
						Debug.Log (objektuSkripts.punkti);
						break;
					

					case "Cements":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [8]);
						objektuSkripts.punkti++;
						break;

					case "e46":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						objektuSkripts.punkti++;
						break;
					case "e61":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						objektuSkripts.punkti++;
						break;

					case "Eskavators":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [7]);
						objektuSkripts.punkti++;
						break;

					case "Policija":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [5]);
						objektuSkripts.punkti++;
						break;
					case "Traktors1":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [6]);
						objektuSkripts.punkti++;
						break;

					case "Traktors5":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [9]);
						objektuSkripts.punkti++;
						break;

					case "Ugunsdzeseji":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [10]);
						objektuSkripts.punkti++;
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
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.b2MKoord;
					break; 

				case "Cements":
					objektuSkripts.cementaMasina.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.cemtMKoord;
					break;

				case "e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.e46MKoord;
					break;
				case "e61":
					objektuSkripts.e61.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.e61MKoord;
					break; 

				case "Eskavators":
					objektuSkripts.eskavators.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.eskavMKoord;
					break;

				case "Policija":
					objektuSkripts.policija.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.policijaMKoord;
					break;
				case "Traktors1":
					objektuSkripts.dzeltTraktors.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.dzeltTrakMKoord;
					break; 

				case "Traktors5":
					objektuSkripts.zalTraktors.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.zalTrakMKoord;
					break;

				case "Ugunsdzeseji":
					objektuSkripts.ugunsdzeseji.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.ugunsMKoord;
					break;

			
					}
				}
			}
		//parbauda vai punktu skaits ir vienads ar masinu skaitu
		if (objektuSkripts.punkti == 11)
		{
			//parada pabeigsanas logu un izsledz laika atskaiti
			objektuSkripts.beiguEkrans.SetActive(true);
			objektuSkripts.laiksAktivs = false;
			objektuSkripts.laikaParadisana.GetComponent<Text>().enabled = true;
			//izvada laiku sakotneji to ar mathf noapalojot lietotajam saprotamas vertibas
			objektuSkripts.laikaParadisana.text = "Izpildes Laiks: " + Mathf.Round(objektuSkripts.laiks).ToString() + " sekundēs!";
		}
		}
	}
 
