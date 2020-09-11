/** Sam Carpenter
* Prototype 2
* Makes various things move around
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoGoGo : MonoBehaviour
{
	public float speed = 40;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
