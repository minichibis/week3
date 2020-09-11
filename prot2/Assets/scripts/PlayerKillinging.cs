/** Sam Carpenter
* Prototype 2
* Blesses the player with the power to smite down any entity so foolish as to exist.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKillinging : MonoBehaviour{
	public GameObject projectile;
    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
			Instantiate(projectile, transform.position, transform.rotation);
		}
    }
}
