using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour 
{
    [SerializeField]
    private GameObject[] ballonReference;

    private GameObject spawnedBalloon;

    [SerializeField]
    private Transform upPos, downPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(SpawnBalloon());
    }

    IEnumerator SpawnBalloon() {
        while (true) {
          
          yield return new WaitForSeconds(Random.Range(0, 2));

          randomIndex = Random.Range(0, ballonReference.Length);
          randomSide = Random.Range(0, 3);

          spawnedBalloon = Instantiate(ballonReference[randomIndex]);

          // up side
          if (randomSide == 0) {
                spawnedBalloon.transform.position = upPos.position;
                spawnedBalloon.GetComponent<Balloon>().speed = -Random.Range(4,10);
          }
           

          else
          {
                 spawnedBalloon.transform.position = downPos.position;
                spawnedBalloon.GetComponent<Balloon>().speed = -Random.Range(4,10);
          }
        } // while loop
    }

}
