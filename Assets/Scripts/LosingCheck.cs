using UnityEngine;
using System.Collections;

public class LosingCheck : MonoBehaviour {
	void OnTriggerExit2D (Collider2D player)
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}