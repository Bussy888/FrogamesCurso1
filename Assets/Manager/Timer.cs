using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public float maxTime = 60f;
	private float countdown = 0f;

	// Use this for initialization
	void Start () {
		countdown = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
		countdown -= Time.deltaTime;
		Debug.Log("Tiempo: " + countdown);
		if(countdown <= 0)
		{
			Debug.Log("Has perdido!!");
			Coin.coinsCount = 0;
			SceneManager.LoadScene("SampleScene");
		}
	}
}
