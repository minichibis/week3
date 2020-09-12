/** Sam Carpenter
* Prototype 2
* shows score
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
	public Text textbox;
	public int score = 0;
	
    // Start is called before the first frame update
    void Start()
    {
		score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
