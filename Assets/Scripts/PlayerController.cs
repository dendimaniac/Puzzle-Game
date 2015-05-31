using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;
	[HideInInspector]
	public float dir;

	private bool isMoving = false;

	void Update()
	{
		if ((GetComponent<Rigidbody2D> ().velocity.x == 0f) && (GetComponent<Rigidbody2D> ().velocity.y == 0f))
		{
			isMoving = false;
		}
		else
		{
			isMoving = true;
		}
		if (Input.GetButtonDown ("Horizontal"))
		{
			if (!isMoving)
			{
				dir = Input.GetAxis ("Horizontal");
				MoveHorizontally();
			}
		}
		if (Input.GetButtonDown ("Vertical"))
		{
			if (!isMoving)
			{
				dir = Input.GetAxis ("Vertical");
				MoveVertically();
			}
		}
	}

	void MoveVertically()
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, Mathf.Sign(dir) * moveSpeed * Time.deltaTime);
	}

	void MoveHorizontally()
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (Mathf.Sign(dir) * moveSpeed * Time.deltaTime, 0);
	}
}