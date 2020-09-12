/** Sam Carpenter
* Challenge 2
* slightly edited base script.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;
	public bool gameo = false;

    // Start is called before the first frame update
    void Start()
    {
		gameo = false;
        StartCoroutine("SpawnRandomBall");
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall ()
    {
		while (!gameo){
			// Generate random ball index and random spawn position
			Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

			// instantiate ball at random spawn location
			Instantiate(ballPrefabs[Random.Range(0, ballPrefabs.Length)], spawnPos, ballPrefabs[0].transform.rotation);
			yield return new WaitForSeconds(Random.Range(3f, 5f));
		}
    }

}
