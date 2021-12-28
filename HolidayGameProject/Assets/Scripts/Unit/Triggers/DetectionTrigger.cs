using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionTrigger : MonoBehaviour
{
    public Unit_Logic unitLogic;
    private void OnTriggerEnter(Collider other)
    {
        Unit_Logic target = other.GetComponent("Unit_Logic") as Unit_Logic;
        if (target != null && !other.gameObject.CompareTag(unitLogic.unitStats.team)) unitLogic.DetectTarget(target);
    }

    private void OnTriggerExit(Collider other)
    {
        Unit_Logic target = other.GetComponent("Unit_Logic") as Unit_Logic;
        if (target != null && !other.gameObject.CompareTag(unitLogic.unitStats.team)) unitLogic.ForgetTarget(target);
    }
}
