/** Sam Carpenter
* Challenge 2
* slightly edited base script.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
		GameObject.FindGameObjectWithTag("GameController").GetComponent<TextManager>().score++;
        Destroy(gameObject);
    }
}
