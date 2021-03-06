﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : enemy{

    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    
    // Start is called before the first frame update
    void Start(){

        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position,moveSpeed * Time.deltaTime);
        }
    }
}
