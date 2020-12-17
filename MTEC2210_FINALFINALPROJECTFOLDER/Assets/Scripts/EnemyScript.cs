 ﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{

    private Transform enemyHolder;
    public float speed;

    public GameObject shot;
    public float fireRate = 0.997f;


    void Start(){
        InvokeRepeating ("MoveEnemy", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform> ();
    }


    void MoveEnemy(){
          enemyHolder.position += Vector3.right * speed;

          foreach (Transform enemy in enemyHolder){
              if (enemy.position.x < -9.5 || enemy.position.x > 9.5){
                speed = -speed;
                enemyHolder.position += Vector3.down * 0.5f;
                return;
              }

              if(Random.value > fireRate) {
                  Instantiate (shot, enemy.position, enemy.rotation);

              }

          }

          if (enemyHolder.childCount <= 8) {
              CancelInvoke ();
              InvokeRepeating ("MoveEnemy", 0.1f, 0.25f);
          }

    }
}
