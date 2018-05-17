using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class buttonscript : MonoBehaviour,IVirtualButtonEventHandler {
	public GameObject resume, video, expert;
	// Use this for initialization

	void Start () {
		VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour> ();
		for (int i = 0; i < 3; i++) {
			vrb [i].RegisterEventHandler (this);
		}
		resume.SetActive (false);
		video.SetActive (false);
		expert.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		if (vb.VirtualButtonName == "resume") {
			resume.SetActive (true);
			video.SetActive (false);
			expert.SetActive (false);
		}

		else if (vb.VirtualButtonName == "video") {
			resume.SetActive (false);
			video.SetActive (true);
			expert.SetActive (false);
		}

		else if (vb.VirtualButtonName == "expert") {
			resume.SetActive (false);
			video.SetActive (false);
			expert.SetActive (true);
		}
	}
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		resume.SetActive (false);
		video.SetActive (false);
		expert.SetActive (false);
			
	}
}
