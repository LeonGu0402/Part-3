using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Building : MonoBehaviour
{
    public GameObject log;
    public GameObject shelf;
    public GameObject bucket;

    public AnimationCurve animationCurve;
    public float lerpTimer = 0;
    public Vector3 begin;
    public Vector3 end;
    float interpolation;

    Coroutine Build;

    // Start is called before the first frame update
    void Start()
    {
        shelf.transform.localScale = begin;
        log.transform.localScale = begin;
        bucket.transform.localScale = begin;
        Build = StartCoroutine(BuildingLerp()); 
    }


    IEnumerator BuildingLerp()
    {
        //build shelf
        while (shelf.transform.localScale != end)
        {
            interpolation = animationCurve.Evaluate(lerpTimer);
            shelf.transform.localScale = Vector3.Lerp(begin, end, interpolation);
            lerpTimer += 0.5f * Time.deltaTime;
            yield return null;
        }
        //build log
        lerpTimer = 0;
        while (log.transform.localScale != end)
        {
            interpolation = animationCurve.Evaluate(lerpTimer);
            log.transform.localScale = Vector3.Lerp(begin, end, interpolation);
            lerpTimer += 0.5f * Time.deltaTime;
            yield return null;
        }
        //build bucket
        lerpTimer = 0;
        while (bucket.transform.localScale != end)
        {
            interpolation = animationCurve.Evaluate(lerpTimer);
            bucket.transform.localScale = Vector3.Lerp(begin, end, interpolation);
            lerpTimer += 0.5f * Time.deltaTime;
            yield return null;
        }

    }
}
