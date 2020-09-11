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
			timer = Random.Range(10, 40);
			SpawnDude();
		}
    }
	
	void SpawnDude(){
		Vector3 v = new Vector3(Random.Range(-14, 14), 0, 20);
		Quaternion r = new Quaternion(0, 180, 0, 0);
		GameObject dude = spawnables[Random.Range(0, spawnables.Length)];
		Instantiate(dude, v, r);
	}
}
