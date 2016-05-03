using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {


    public int damagePerShot = 20;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemies")
        {
            EnemyHealth enemyHealth = col.gameObject.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damagePerShot);
                Destroy(gameObject, 0f);
            }
           

        }
        else if (col.gameObject.tag != "Enemies")
        {
             Destroy(gameObject, 0f);
            
        }
    }
}
