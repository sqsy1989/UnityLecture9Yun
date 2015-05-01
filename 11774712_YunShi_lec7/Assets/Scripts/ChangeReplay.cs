using UnityEngine;
using System.Collections;

public class ChangeReplay : MonoBehaviour {


	
	// Update is called once per frame
	public void ChangeToReplay (int index) {
		Application.LoadLevel (index);
	
	}
}
