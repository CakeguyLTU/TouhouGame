using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Projectile Settings")]
    public int numberOfProjectiles;
    public float projectileSpeed;
    public GameObject Projectile;

    [Header("Private Variables")]
    private Vector3 startPoint;
    private const float radius = 1F;
    public float nextFire = 2;
    public float fireRate = 2;


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextFire)
        {
            nextFire = Time.time + fireRate;
            startPoint = transform.position;
            SpawnProjectile(numberOfProjectiles);
        }
    }

    void SpawnProjectile(float _numberOfProjectiles)
    {

        float angleStep = 360f / _numberOfProjectiles;
        float angle = 0f;

        for (int i = 0; i <= _numberOfProjectiles - 1; i++)
        {
            // Direction calculations.
            float projectileDirXPosition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float projectileDirYPosition = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;


            Vector3 projectileVector = new Vector3(projectileDirXPosition, projectileDirYPosition, 0);
            Vector3 projectileMoveDirection = (projectileVector - startPoint).normalized * projectileSpeed;

            GameObject tmpObj = Instantiate(Projectile, startPoint, Quaternion.identity);
            tmpObj.GetComponent<Rigidbody>().velocity = new Vector3(projectileMoveDirection.x, 0, projectileMoveDirection.y);

            angle += angleStep;
        }
    }
}


// Update is called once per frame


