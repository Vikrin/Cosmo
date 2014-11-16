using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width/4.5f, Screen.height/6-30, Screen.width/10, Screen.height/15), "Sun"))
		{
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(Screen.width/4.5f, Screen.height/5-10, Screen.width/10, Screen.height/15), "Mercury"))
		{
			Application.LoadLevel(2);
		}
		if(GUI.Button(new Rect(Screen.width/4.5f, Screen.height/4+3, Screen.width/10, Screen.height/15), "Venus"))
		{
			Application.LoadLevel(3);
		}
		if(GUI.Button(new Rect(Screen.width/4.5f, Screen.height/3, Screen.width/10, Screen.height/15), "Earth"))
		{
			Application.LoadLevel(4);
		}
		if(GUI.Button(new Rect(Screen.width/4.5f, Screen.height/2-40, Screen.width/10, Screen.height/15), "Mars"))
		{
			Application.LoadLevel(5);
		}
		if(GUI.Button(new Rect(Screen.width/2.5f, Screen.height/6-30, Screen.width/10, Screen.height/15), "Jupiter"))
		{
			Application.LoadLevel(6);
		}
		if(GUI.Button(new Rect(Screen.width/2.5f, Screen.height/5-10, Screen.width/10, Screen.height/15), "Saturn"))
		{
			Application.LoadLevel(7);
		}
		if(GUI.Button(new Rect(Screen.width/2.5f, Screen.height/4+3, Screen.width/10, Screen.height/15), "Uranus"))
		{
			Application.LoadLevel(8);
		}
		if(GUI.Button(new Rect(Screen.width/2.5f, Screen.height/3, Screen.width/10, Screen.height/15), "Neptune"))
		{
			Application.LoadLevel(9);
		}
	}

}
