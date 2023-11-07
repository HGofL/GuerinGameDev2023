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
    
    // Start is called before the first frame update
    void Start()
    {
        
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
            }
        }
    }
}
