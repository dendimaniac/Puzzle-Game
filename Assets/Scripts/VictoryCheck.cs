using UnityEngine;
using System.Collections;

public class VictoryCheck : MonoBehaviour {
	void OnTriggerEnter2D()
	{
		UIManager.hasWon = true;
	}
}
