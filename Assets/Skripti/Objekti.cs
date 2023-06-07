using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	public GameObject beiguEkrans;
	public GameObject zvaigzne1;
	public GameObject zvaigzne2;
	public GameObject zvaigzne3;
	//pievieno punktu mainigo kura atradisies punktu skaits
	public int punkti = 0;
	//pievieno laika mainigo



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
	public float laiks;
	//mainigais kurs nosaka vai laiks tiek skaitīts
	public bool laiksAktivs = true;
	// Pievieno Text objektu kur atradīsies laiks
	public Text laikaParadisana;
	void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atraMKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussMKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		//Sākotnējās pozīcijas noteikšana
		b2MKoord = b2.GetComponent<RectTransform> ().localPosition;
		cemtMKoord = cementaMasina.GetComponent<RectTransform> ().localPosition;
		e46MKoord = e46.GetComponent<RectTransform> ().localPosition;
		e61MKoord = e61.GetComponent<RectTransform> ().localPosition;
		eskavMKoord = eskavators.GetComponent<RectTransform> ().localPosition;
		policijaMKoord = policija.GetComponent<RectTransform> ().localPosition;
		dzeltTrakMKoord = dzeltTraktors.GetComponent<RectTransform> ().localPosition;
		zalTrakMKoord = zalTraktors.GetComponent<RectTransform> ().localPosition;
		ugunsMKoord = ugunsdzeseji.GetComponent<RectTransform> ().localPosition;
	
		//Beigu ekrāna izslēgšana sākumā, lai nebūtu redzams
		beiguEkrans.SetActive (false);

		//Laika tekstloga izslēgšana sākumā, lai nebūtu redzams
		laikaParadisana.GetComponent<Text>().enabled = false;
	}

}
