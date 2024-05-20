using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    
    public GameObject player;
    public float speed;
    public Transform target;

    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = UnityEngine.Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
