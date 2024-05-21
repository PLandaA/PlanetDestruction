using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform otherPlanet;

    public float speed;

    public float minSpeed;
    public float maxSpeed;

    public float secondsToMaxDiff;

    // Update is called once per frame
    void Update ()
    {
        try {
            speed = Mathf.Lerp(minSpeed, maxSpeed, changeDifficulty());
            transform.position = Vector2.MoveTowards(transform.position, otherPlanet.position, speed * Time.deltaTime);
        } catch  { };
    }

    float changeDifficulty () {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDiff);

    }

}
