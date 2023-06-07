using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {


		void Start()
		{
			// Switch to 1280 x 600 
		Screen.SetResolution(1280, 600, false);
		}
	public void UzSakumu(){
		SceneManager.LoadScene ("Sakums", LoadSceneMode.Single);
	}
	public void UzPilsetu(){
		SceneManager.LoadScene ("Pilseta", LoadSceneMode.Single);
	}
	public void UzBeigam(){
		SceneManager.LoadScene ("Beigas", LoadSceneMode.Single);
	}
	public void apturet(){
		Application.Quit ();
		}
	}

