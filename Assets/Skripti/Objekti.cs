using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	//Mašīnas, kuras jānovieto pareizajā vietā 
	public GameObject b2;
	public GameObject cementaMasina;
	public GameObject e46;
	public GameObject e61;
	public GameObject eskavators;
	public GameObject policija;
	public GameObject dzeltTraktors;
	public GameObject zalTraktors;
	public GameObject ugunsdzeseji;
	public float laiks;
	public int punkti=0;


	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraMKoord;
	[HideInInspector]
	public Vector2 bussMKoord;
	//Sākotnējās pozīcijas uzglabāšana
	[HideInInspector]
	public Vector2 b2MKoord;
	[HideInInspector]
	public Vector2 cemtMKoord;
	[HideInInspector]
	public Vector2 e46MKoord;
	[HideInInspector]
	public Vector2 e61MKoord;
	[HideInInspector]
	public Vector2 eskavMKoord;
	[HideInInspector]
	public Vector2 policijaMKoord;
	[HideInInspector]
	public Vector2 dzeltTrakMKoord;
	[HideInInspector]
	public Vector2 zalTrakMKoord;
	[HideInInspector]
	public Vector2 ugunsMKoord;
	public Canvas kanva;
	public AudioSource skanasAvots;
	public AudioClip[] skanaKoAtskanot;
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;
	void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atraMKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussMKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		//Sākotnējās pozīcijas noteikšana
		b2MKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		cemtMKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		e46MKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		e61MKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		eskavMKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		policijaMKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		dzeltTrakMKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		zalTrakMKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		ugunsMKoord = autobuss.GetComponent<RectTransform> ().localPosition;
	}

}
