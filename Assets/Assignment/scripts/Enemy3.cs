using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : tankBehaviour
{
    float fireTiming;


    private void Start()
    {
        fireTiming = Random.Range(0, 2);
        StartCoroutine(fire());
    }


    protected override void movement()
    {
        tankSpeed = 3f;
        base.movement();
    }

    IEnumerator fire()
    {
        yield return new WaitForSeconds(fireTiming);
        Instantiate(missile, fireSpwanpoint.position, fireSpwanpoint.rotation);
        fireTiming = Random.Range(2, 4);
        yield return new WaitForSeconds(fireTiming);
        Instantiate(missile, fireSpwanpoint.position, fireSpwanpoint.rotation);


    }
}
