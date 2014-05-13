using UnityEngine;
using System.Collections;

public class Toggler : MonoBehaviour {
	
	public GameObject traditionalCam;	
	public GameObject vrCam;
	bool traditional = false;

	// Use this for initialization
	void Start () {
		traditionalCam = transform.FindChild("Traditional FPS").gameObject;
		vrCam = transform.FindChild("VR FPS").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Fire1"))
		{
			traditional = !traditional;

			if (traditional)
			{
				traditionalCam.SetActive(true);
				vrCam.SetActive(false);
			}
			else
			{
				traditionalCam.SetActive(false);
				vrCam.SetActive(true);
			}
		}
	}
}
