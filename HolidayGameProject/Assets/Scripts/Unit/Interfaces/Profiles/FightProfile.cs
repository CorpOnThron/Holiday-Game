using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface FightProfile
{
    void attack(List<Unit_Logic> targets, Stats unitStats);
}
