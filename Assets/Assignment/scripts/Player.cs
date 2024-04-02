using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : tankBehaviour
{   //child class of tankBehaviour
    public Transform fireSpwanpoint;
    public GameObject missile;
    Boolean fireCooldown = false;

    //player have unqiue control, so overrides it
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
        if (!fireCooldown && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(fire());
        }
        
    }

    //use two coroutine to create fire missile fuction and fire cooldown counter
    IEnumerator fire()
    {
        Instantiate(missile, fireSpwanpoint.position, fireSpwanpoint.rotation);
        fireCooldown = true;
        yield return new WaitForSeconds(1);
        StartCoroutine(coolDown());
    }

    IEnumerator coolDown()
    {
        fireCooldown = false;
        yield return null;
    }
}
