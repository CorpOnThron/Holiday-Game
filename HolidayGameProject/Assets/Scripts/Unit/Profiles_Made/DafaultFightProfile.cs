using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DafaultFightProfile : FightProfile
{  
    //do I need this constructor? question for later
    public DafaultFightProfile() {
    
    }
    public void attack(List<Unit_Logic> targets, Stats unitStats)
    {
        unitStats.unitState = UnitState.fight;
        //TODO implement attack
        //targets[0].
    }
}
