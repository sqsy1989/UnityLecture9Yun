using UnityEngine;
using System.Collections;

public class ChangeScrene : MonoBehaviour {


	
	// Update is called once per frame
	 public void ChangeScreneTo (int index) {
		Application.LoadLevel (index);
	}
}
