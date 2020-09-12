/** Sam Carpenter
* Challenge 2
* makes text look pretty
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
	public Text scoretxt;
	public int score;
	
	public Text healthtext;
	public int health;
	
	public Text gameotext;
	public Text restartxt;
	
    // Start is called before the first frame update
    void Start(){
        gameotext.gameObject.SetActive(false);
		restartxt.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        scoretxt.text = "" + score;
		healthtext.text = "" + health;
		
		//end states
		if(health <= 0){
			GetComponent<SpawnManagerX>().gameo = true;
			gameotext.gameObject.SetActive(true);
			restartxt.gameObject.SetActive(true);
			gameotext.text = "GAME OVER";
		}else if(score >= 5){
			GetComponent<SpawnManagerX>().gameo = true;
			gameotext.gameObject.SetActive(true);
			restartxt.gameObject.SetActive(true);
			gameotext.text = "YOU   WIN!";
		}
		
		//restart game after ended
		if(Input.GetKeyDown(KeyCode.R) && GetComponent<SpawnManagerX>().gameo){
			UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
		}
    }
}
