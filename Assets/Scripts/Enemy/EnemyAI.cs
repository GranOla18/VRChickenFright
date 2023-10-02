using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float enemyView;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator enemyAnimator;
    [SerializeField] private PlayerManager player;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        enemyAnimator = GetComponent<Animator>();
        player = PlayerManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(agent.transform.position, player.transform.position) < enemyView)
        {
            agent.SetDestination(player.transform.position);

            if(agent.speed > 2.5)
            {
                enemyAnimator.SetBool("Run", true);
                enemyAnimator.SetBool("Walk", false);
            }
            else
            {
                enemyAnimator.SetBool("Walk", true);
                enemyAnimator.SetBool("Run", false);
            }
        }

        else
        {
            agent.SetDestination(this.transform.position);
            //enemyAnimator.SetTrigger("Idle");
            enemyAnimator.SetBool("Walk", false);
            enemyAnimator.SetBool("Run", false);
        }
    }

    private void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = new Color(1, 0.92f, 0.016f, 0.25f);
        Gizmos.DrawSphere(transform.position, enemyView);
    }
}
