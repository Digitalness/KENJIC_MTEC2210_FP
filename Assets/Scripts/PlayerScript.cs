using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

  private Transform player;
  public float speed;
  public float maxBound, minBound;

    void Start() {
        player = GetComponent<Transform> ();
    }


    void Update() {
        float h = Input.GetAxis ("Horizontal");

        if (player.position.x < minBound && h < 0)
            h = 0;
        else if (player.position.x > maxBound && h > 0)
            h = 0;

            player.position += Vector3.right * h * speed; 
    }
}
