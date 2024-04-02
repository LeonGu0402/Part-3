using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankBehaviour : MonoBehaviour
{   //parents class for every tank
    public float tankSpeed = 5f;
    public GameObject explosionImage;
    Boolean move = true;

    

    private void Start()
    {
        
    }

    protected void FixedUpdate()
    {
        if (move)
        {
            movement();
        }

        
        
    }

    protected virtual void movement()
    {
        transform.Translate(Vector3.right * tankSpeed * Time.deltaTime);
    }

    protected virtual IEnumerator explosion()
    {
        move = false;
        Instantiate(explosionImage, gameObject.transform);
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

    protected void hit()
    {
        StartCoroutine(explosion());
    }
}
