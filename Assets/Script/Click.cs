using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text spc;

	public UnityEngine.UI.Text SoulCounter;
	public float soul = 0.00f;
	public int soulperclick = 10;

	void Update(){
		SoulCounter.text = "Soul: " + soul;
		spc.text = soulperclick + " soul/click";
	
	}

	public void Clicked(){
		soul += soulperclick;

	}
}
