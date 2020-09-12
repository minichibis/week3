/** Sam Carpenter
* Prototype 2
* makes the blob of fish DESTROY
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ULTIMATEPAININCINERATION : MonoBehaviour
{
	private ScoreDisplay scoret;
	
	void Start(){
		scoret = GameObject.FindGameObjectWithTag("score").GetComponent<ScoreDisplay>();
	}
	
    private void OnTriggerEnter(Collider other){
		if(!GameObject.FindGameObjectWithTag("score").GetComponent<HealthSystem>().gameOver)scoret.score += other.GetComponent<GoGoGo>().score;
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
