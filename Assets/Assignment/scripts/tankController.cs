using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankController : MonoBehaviour
{
    public static float maxTankNumber = 5;

    public static void tankGernater(GameObject tank, Transform location)
    {
        Instantiate(tank, location);
    }

}
