using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


//now lets maks them follow the player

Rigidbody2D rb;
GameObject target;
//Player player;

GameObject SpawnWolfStart;

float moveSpeed;
Vector3 directionToTarget;
private float leftEdge;
    public void Start()
    {


    }
    public void Update()
    {     
        MoveEnemy();        
    }
    public void MoveEnemy(){

         SpawnWolfStart=GameObject.Find("SpawnWolfStart");
         target=GameObject.Find("Player");
         rb=GetComponent<Rigidbody2D>();        
         moveSpeed=Random.Range(1f,2f);

            if(target!=null){
                if(target.transform.position.x<=SpawnWolfStart.transform.position.x){
                    directionToTarget=(target.transform.position-transform.position).normalized;
                    rb.velocity=new Vector2(directionToTarget.x*moveSpeed,directionToTarget.y*moveSpeed);
                    transform.position +=Vector3.right*Time.deltaTime*2;
                                 }
                            }

                else{
                     rb.velocity=Vector3.zero;      
                    }
        
    }
}

