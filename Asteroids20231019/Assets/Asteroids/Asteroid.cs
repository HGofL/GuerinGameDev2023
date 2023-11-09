//Hannah Guerin - 11/7/23 - How asteroids move, spawn and die

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    //how many hits it will take
    public float life;
    public float move_speed;
    private Rigidbody rb;

    [HideInInspector] public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 dir = (Vector3.zero - transform.position).normalized;
        rb.AddForce(dir * move_speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player Bullet")
        {
            Destroy(other.transform.parent.gameObject);
            life--;

            if (life <= 0)
            {
                Destroy(gameObject);
                spawner.GetComponent<Spawner>().asteroids_count--;
                spawner.GetComponent<Spawner>().CheckAsteroidCount();
            }
        }
    }
}
