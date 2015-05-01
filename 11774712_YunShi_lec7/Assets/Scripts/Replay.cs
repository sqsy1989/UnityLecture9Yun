using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour {


	// Update is called once per frame
	public void Change (int index) {
		Application.LoadLevel (index);
	
	}
}
