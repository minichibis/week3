/** Sam Carpenter
* Prototype 2
* makes the blob of fish DESTROY
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ULTIMATEPAININCINERATION : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
