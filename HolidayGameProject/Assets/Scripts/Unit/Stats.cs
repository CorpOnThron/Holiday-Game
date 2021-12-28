using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public string team;
    public double health;
    public double damage;
    public float speed;
    public double attackRange;
    public UnitState unitState;
    public Transform position;
    public bool dead = false;
    public FightProfile fightProfile = new DafaultFightProfile();
    public MoveProfile moveProfile = new DefaultMoveProfile();
    public ChaseProfile chaseProfile = new DefaultChaseProfile();

    public void TakeDamage(double damage)
    {
        health -= damage;
    }
}
