using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraMKoord;
	[HideInInspector]
	public Vector2 bussMKoord;
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
	}

}
