using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour {
	public int myNumber = 30;
	public int total;
	private int superSecret;

	public int n1 = 5;
	public int n2 = 0;
	// Use this for initialization
	void Start () {
		total = myNumber - 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return))
		{
			AddTwoNumber();
		}
	}
	void AddTwoNumber() //Void por defecto es privado
	{
		Debug.Log(n1 + n2);
	}
}
