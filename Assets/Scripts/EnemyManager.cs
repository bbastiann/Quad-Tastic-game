using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    
    [SerializeField] private GameObject myEnemy;
    private Vector3 enemyPos;
    
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float enemyDistance = 10f;
    //--------------Stats Enemigo-----------------------------
    
    
    private float distancia;
    // Start is called before the first frame update

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        SeguirPlayer();
    }

    void SeguirPlayer()
    {
        
        
        // Move our position a step closer to the target.
        float step = moveSpeed*Time.deltaTime+0.02f; 
        // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, myEnemy.transform.position, step);

        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, myEnemy.transform.position) < 0.001f)
        {
            // Swap the position of the cylinder
            transform.Translate(transform.position*step);
            myEnemy.transform.position *= -1.0f;
        }
    }
}
