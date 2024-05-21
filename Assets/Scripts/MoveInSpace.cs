using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInSpace : MonoBehaviour
{
    
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetPosition;

    public float minSpeed;
    public float maxSpeed;

    float speed;

    public float secondsToMaxDiff;

    public GameObject restartPanel;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = getRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetPosition) {
            speed = Mathf.Lerp(minSpeed, maxSpeed, changeDifficulty());
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        } else {
            targetPosition = getRandomPosition();
        }

    }

    Vector2 getRandomPosition() {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }

   

    float changeDifficulty () {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDiff);

    }


}
