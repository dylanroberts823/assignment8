using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class DiamondText : MonoBehaviour {

	public GameObject helicopter;
	private Text text;
	private int diamonds;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (helicopter != null) {
			diamonds = helicopter.GetComponent<HeliController>().diamondTotal;
		}
		text.text = "Diamonds: " + diamonds;
	}
}
