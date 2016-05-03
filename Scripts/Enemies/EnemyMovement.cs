using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    NavMeshAgent nav;
    Animator anim;
    bool walking;


    void Awake()
    {
      // anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        //walking = true;
        //anim.SetBool("IsWalking", walking);
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
        

    }
}