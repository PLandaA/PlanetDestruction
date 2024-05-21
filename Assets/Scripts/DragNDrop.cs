using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour {
    bool moveAllowed;
    Collider2D col;
    AudioSource audioSource;


   public GameObject dieEffect;
    public GameObject moveAnim;


    private GameManager manager;

    // Start is called before the first frame update
    void Start () {
        manager = FindObjectOfType<GameManager>();
        audioSource = GetComponent<AudioSource>();

        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began) {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider) {
                    moveAllowed = true;
                    Instantiate(moveAnim, transform.position, Quaternion.identity);
                    audioSource.Play();


                }

            }
            if (touch.phase == TouchPhase.Moved) {
                if (moveAllowed) {
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
                }
            }
            if (touch.phase == TouchPhase.Ended) {
                moveAllowed = false;
            }

        }

        //Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //bool touchingSprite = GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);
        //moveAllowed = moveAllowed && Input.GetMouseButtonDown(0);
        //if (touchingSprite) {
        //    //If we've pressed down on the mouse (or touched on the iphone)
        //    if (Input.GetMouseButtonDown(0)) {
        //        moveAllowed = true;
        //        audioSource.Play();
        //        Instantiate(moveAnim, transform.position, Quaternion.identity);
        //    }
        //}
        //if (moveAllowed) {
        //    transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
        //                                     Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
        //                                     0.0f);
        //}

    }

    private void OnTriggerEnter2D (Collider2D collision) {
        if (collision.tag == "Planets") {
            Instantiate(dieEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            manager.GameOver();
			

        }
    }


}
