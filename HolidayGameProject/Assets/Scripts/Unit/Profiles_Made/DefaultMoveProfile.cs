using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMoveProfile : MoveProfile
{
    public DefaultMoveProfile() {}

    public void move(Transform target, Stats unitStats)
    {
        unitStats.unitState = UnitState.move;
        //TODO implement movement
    }
}
