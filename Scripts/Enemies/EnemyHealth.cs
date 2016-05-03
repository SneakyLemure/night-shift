using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public int scoreValue = 10;

   // CapsuleCollider capsuleCollider;
   // Animator anim;
  //  bool isDead;

	void Awake ()
    {
        //Setting up the references
        //anim = GetComponent<Animator> ();
       // capsuleCollider = GetComponent<CapsuleCollider>();
        currentHealth = startingHealth;
    }

    public void TakeDamage (int damageAmount)
    {
       // if (isDead)
         //   return;

        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            //Death();
            Destroy(gameObject, 3f);
        }
    }

    void Death ()
    {
      //  isDead = true;
        //capsuleCollider.isTrigger = true;
        //anim.SetTrigger("Dead");
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        Destroy(gameObject, 3f);
    }

}
