/*
 * 
 * NAMESPACE
 * 
 */

using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour {
	public static int coinsCount = 0;

	// Use this for initialization
	void Start () {
		Coin.coinsCount++;
		Debug.Log("Ahora Hay " + Coin.coinsCount + " monedas");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player") == true)
		{
			Debug.Log("El personaje colisiono con la moneda");
			Coin.coinsCount--;
			if(Coin.coinsCount == 0)
			{
				Debug.Log("Juego Completado");
				GameObject gameManager = GameObject.Find("GameManager");
				Destroy(gameManager);
				GameObject[] fireworkSystem = GameObject.FindGameObjectsWithTag("Firework");
				foreach(GameObject firewors in fireworkSystem)
				{
					firewors.GetComponent<ParticleSystem>().Play();
				}
			}
			Destroy(gameObject);
		}
	}
}
