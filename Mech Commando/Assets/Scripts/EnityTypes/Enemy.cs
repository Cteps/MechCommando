﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MovingEntity
{
    [SerializeField]
    protected int damageOutput;
    [SerializeField]
    protected int movementType;
    [SerializeField]
    protected int accuracy;

    AIMovementManager movementManager;


    protected override void Awake()
    {
        base.Awake();

        movementManager = GetComponent<AIMovementManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }






}
