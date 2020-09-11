/** Sam Carpenter
* Prototype 2
* infinite chickens for everyone.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	private int timer = 30;
	public GameObject[] spawnables;
    // Update is called once per frame
    void Update() {
        timer--;
		if(timer <= 0){
			Vector3 v = new Vector3(Random.Range(-14, 14), 0, 20);
			Quaternion r = new Quaternion(0, 180, 0, 0);
			Instantiate(spawnables[Random.Range(0, spawnables.Length)], v, r);
			timer = Random.Range(10, 40);
		}
    }
}
