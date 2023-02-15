using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    [SerializeField] private float speed = 10.0f;
    public float xRage = 8.3f;
    public float zRage = 4.4f;

    [SerializeField] private GameObject projectilePrefab;
    public float nextFire = 2;
    public float fireRate = 2;


    void Start()
    {

    }

    private void FixedUpdate()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);


        if (transform.position.x < -xRage)
        {

            transform.position = new Vector3(-xRage, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRage)
        {

            transform.position = new Vector3(xRage, transform.position.y, transform.position.z);
        }


        if (transform.position.z < -zRage)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, -zRage);
        }
        if (transform.position.z > zRage)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, zRage);
        }


        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            GetComponent<AudioSource>().Play();
        }
    }


    void Update()
    {

    }
}