using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefabs;
    public Transform spawnPoint;
    Vector3 dashDerection = new Vector3();
    public float speed = 6f;



    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        dashDerection = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        destination = transform.position + dashDerection;
        Invoke("stop", 0.5f);
        base.Attack();
        Instantiate(daggerPrefabs, spawnPoint.position, spawnPoint.rotation);
        Instantiate(daggerPrefabs, spawnPoint.position + new Vector3(1, 0, 0), spawnPoint.rotation);
    }

    void stop()
    {
        destination = transform.position;
    }

}
