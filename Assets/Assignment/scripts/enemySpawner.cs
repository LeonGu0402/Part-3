using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public List<GameObject> tankTypes = new List<GameObject>();
    public List<Transform> spawnPoint = new List<Transform>();
    float tankCount = 0;
    

    private void Update()
    {
        enemySpawn();
    }

    public void enemySpawn()
    {

        //see if it reaches the maxium
        if (tankCount < tankController.maxTankNumber)
        {
            tankController.tankGernater(tankTypes[Random.Range(0,3)], spawnPoint[Random.Range(0, 3)]);
            tankCount += 1;
        }
    }

    public void tankKill()
    {
        tankCount -= 1;
    }

}
