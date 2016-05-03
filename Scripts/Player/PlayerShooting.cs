using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{

    public Rigidbody projectile;
    public Transform shotPos;
    public float shotForce = 1000f;
   
    public float rateOfFire = 0.3f;




    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonUp("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot ()
    {
        Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
        shot.AddForce(shotPos.forward * shotForce);


      
    }

   
}