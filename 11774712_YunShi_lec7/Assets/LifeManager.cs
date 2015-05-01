using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LifeManager : MonoBehaviour {

	public static int lives;
	Text text;
	
	// Use this for initialization
	void Start () {
		//add more comments
		text = GetComponent<Text> ();
		lives=3;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Lives: " + lives;
	}
	
	
	public static void LifeControl(int life)
	{
		lives=lives-life;
	}

}
