/** Sam Carpenter
* Prototype 2
* Makes the player move around on one axis, clamped into a box
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveing : MonoBehaviour
{
    public float hInput;
	public float maxdist = 0;
	public float hspeed = 0;
	private float c = 0;
	


    void Update(){
		hInput = Input.GetAxis("Horizontal");
		c = Mathf.Clamp(transform.position.x + Time.deltaTime * hspeed * hInput, maxdist * -1, maxdist);
		transform.position = new Vector3(c, 0, 0);
    }
}
