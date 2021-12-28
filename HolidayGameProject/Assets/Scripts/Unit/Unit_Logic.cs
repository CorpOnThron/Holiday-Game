using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Logic : MonoBehaviour
{

    public Stats unitStats;
    public List<Unit_Logic> targets;

    // Start is called before the first frame update
    void Start()
    {
        targets = new List<Unit_Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!unitStats.dead)
        {
            //main unit loop
            if (targets.Count > 0)
            {
                if (unitStats.chaseProfile.chase(targets, unitStats))
                    unitStats.fightProfile.attack(targets, unitStats);
            }
            else
            {
                //implement move
                //unitStats.moveProfile.move(targets, unitStats);
            }
        }
        else 
        { 

            //implement death here 
        
        }
    }

    public void TakeDamage(double damage) {
        //any modifiers will go here
        unitStats.TakeDamage(damage);
    }

    
}
