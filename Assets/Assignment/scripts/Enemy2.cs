using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : tankBehaviour
{
    //can take more hits
    public float hitTimes = 2;

    //override to make it slow
    protected override void movement()
    {
        tankSpeed = 2f;
        base.movement();
    }

    //reduce hitTimes
    void reduceHittimes()
    {
        hitTimes -= 1;
    }

    protected override void hit()
    {
        reduceHittimes();
        if (hitTimes <= 0)
        {
            base.hit();
        }        
    }

}
