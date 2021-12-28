using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultChaseProfile : ChaseProfile
{
    public DefaultChaseProfile()
    {
    }

    public bool chase(List<Unit_Logic> targets, Stats unitStats) //returns true if should be attacked, false if should not
    {
        if (availibleTarget(targets, unitStats)) {
            return true;
        }
        else
        {
            unitStats.unitState = UnitState.chase;
            Vector3.MoveTowards(unitStats.position.position, findClosestTarget(targets, unitStats), unitStats.speed);
            return false;
        }
    }

    private Vector3 findClosestTarget(List<Unit_Logic> targets, Stats unitStats) {
        Unit_Logic closestTarget = targets[0];
        double prevDistance = Vector3.Distance(unitStats.position.position, targets[0].unitStats.position.position);
        foreach (Unit_Logic target in targets)
        {
            double dist = Vector3.Distance(unitStats.position.position, target.unitStats.position.position);
            if (dist < prevDistance) {
                closestTarget = target;
                prevDistance = dist;
            }
        }
        return closestTarget.unitStats.position.position;
    }

    private bool availibleTarget(List<Unit_Logic> targets, Stats unitStats)
    {
        foreach (Unit_Logic target in targets)
        {
            if (Vector3.Distance(unitStats.position.position, target.unitStats.position.position) < unitStats.attackRange) return true;
        }
        return false;
    }
}
