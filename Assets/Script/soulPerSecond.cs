using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soulPerSecond : MonoBehaviour {

	public UnityEngine.UI.Text spsDisplay;
	public Click click;
	public itemManager[] items;

	void Start(){
		StartCoroutine (AutoTick ());
	}

	void Update(){
		spsDisplay.text = GetSoulPerSec () + " soul/sec";

	}

	public int GetSoulPerSec(){;
		int tick =0;
		foreach(itemManager item in items){
		tick += item.count * item.tickValue;
		}
		return tick;
	}


	public void AutoSoulPerSec(){
		click.soul += GetSoulPerSec ();
	}
	IEnumerator AutoTick(){
		while (true) {
			AutoSoulPerSec ();
			yield return new WaitForSeconds (1);
		}
	}
}
