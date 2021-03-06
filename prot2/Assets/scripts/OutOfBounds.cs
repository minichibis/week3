﻿/** Sam Carpenter
* Prototype 2
* kills whats too far away.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
	private int max = 20;
	private int min = -5;
	public int score = 0;
	
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > max){
			//fishy chunk
			Destroy(gameObject);
		}else if(transform.position.z < min){
			//evil creature
			GameObject.FindGameObjectWithTag("score").GetComponent<HealthSystem>().TakeDamage();
			Destroy(gameObject);
		}
    }
}
