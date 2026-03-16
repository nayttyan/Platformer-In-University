using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PatrolLogic : MonoBehaviour
{
    //public RefactorEnemy refactorEnemyScript;

    [Tooltip("The transform to which the enemy will pace back and forth to.")]
    public Transform[] patrolPoints;

    private int currentPatrolPoint = 0;

    public void Patrol(float walkSpeed)
    {
        Vector3 moveToPoint = patrolPoints[currentPatrolPoint].position;
        transform.position = Vector3.MoveTowards(transform.position, moveToPoint, walkSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveToPoint) < 0.01f)
        {
            currentPatrolPoint++;
            if (currentPatrolPoint > patrolPoints.Length - 1)
            {
                currentPatrolPoint = 0;
            }
        }
    }
}
