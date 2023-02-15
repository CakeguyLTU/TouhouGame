using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCode : MonoBehaviour
{
    public float Damage = 10f;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Enemy")
        {

            Destroy(this.gameObject);
            
        }

        if(hit.tag == "Player")
        {
            var healthComponent = hit.GetComponent<Health>();
            if(healthComponent != null)
            {
                healthComponent.TakeDamage(1);
            }
            
        }
      
    }
}
