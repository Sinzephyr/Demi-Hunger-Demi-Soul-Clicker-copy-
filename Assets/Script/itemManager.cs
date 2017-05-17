using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class itemManager : MonoBehaviour {

	public UnityEngine.UI.Text itemInfo;
	public Click click;
	public float cost;
	public int tickValue;
	public int count;
	public string itemName;
	public Color standard;
	public Color affordable;
	private float baseCost;

	// Use this for initialization
	void Start () {
		baseCost = cost;
	}
	
	// Update is called once per frame
	void Update () {
		itemInfo.text = itemName + "\nCost: " +cost + "\nSoul: " + tickValue + "/s";
		if (click.soul >= cost) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standard;
		}
	}

	public void PurchaseItem(){
		if (click.soul >= cost) {
			click.soul -= cost;
			count += 1;
			cost = Mathf.Round(baseCost * Mathf.Pow (1.15f, count));
		}
	}
}
