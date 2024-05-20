using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 mousePos;
    public GameObject bulletPrefab;
    public Transform firepoint;
    public float firePower = 10f;


    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * firePower);
    }


    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    
    void Update()
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        // Muspekarens position = Muspekaren i skärmen ur kamerans perspektiv


        Vector3 direction = mousePos - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        // vinkeln mellan x o y till muspekaren, konverterat till grader
        
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        //roterar objektet på Z kordinaten baserat på

        
    if(Input.GetMouseButtonDown(0))
    {
        this.Fire();
    }


    }



}
