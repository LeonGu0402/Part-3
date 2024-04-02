using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankBehaviour : MonoBehaviour
{   //parents class for every tank
    public float tankSpeed = 3f;
    public GameObject explosionImage;
    Boolean move = true;

    protected void FixedUpdate()
    {
        if (move)
        {
            movement();
        }
 
    }

    //every tank default moveing partten
    protected virtual void movement()
    {
        transform.Translate(Vector3.left * tankSpeed * Time.deltaTime);
    }

    protected IEnumerator explosion()
    {
        move = false;
        Instantiate(explosionImage, gameObject.transform);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    //missile send message to hit, hit funtion calls explosion
    protected virtual void hit()
    {
        StartCoroutine(explosion());
    }
}
