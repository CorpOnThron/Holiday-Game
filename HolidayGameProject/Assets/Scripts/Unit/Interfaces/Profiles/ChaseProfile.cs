using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ChaseProfile 
{
    bool chase(List<Unit_Logic> targets, Stats unitStats);
}
