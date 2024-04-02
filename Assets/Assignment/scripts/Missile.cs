using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed* Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //send message to interacts with all tank
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("hit", SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
