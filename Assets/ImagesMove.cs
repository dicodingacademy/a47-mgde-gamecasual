using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagesMove : MonoBehaviour {

	int[] posX = new int[] { 0, -18, -36, -54 };
	int idx = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			if (idx < posX.Length - 1)
			{
				idx++;
			}
		}

		if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
			if (idx > 0)
			{
				idx--;
			}
		}

		transform.position = Vector3.MoveTowards(transform.position, 
			new Vector3(posX[idx], transform.position.y), 50 * Time.deltaTime);
	}
}
