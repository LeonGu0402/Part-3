using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : tankBehaviour
{
    public Transform fireSpwanpoint;
    public GameObject missile;
    Boolean fireCooldown = false;

    protected override void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * tankSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * tankSpeed * Time.fixedDeltaTime);
        }
    }

    private void Update()
    {
        if (!fireCooldown)
        {
            StartCoroutine(fire());
        }
        
    }

    IEnumerator fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missile, fireSpwanpoint.position, fireSpwanpoint.rotation);
            fireCooldown = true;
            yield return new WaitForSeconds(1);
            StartCoroutine(coolDown());

        }
    }

    IEnumerator coolDown()
    {
        fireCooldown = false;
        yield return null;
    }
}
