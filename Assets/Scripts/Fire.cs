using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float moveSpeed = 4f;
    Rigidbody2D rb;
    Ship target;
    bool facingUp = false;

    // Start is called before the first frame update
    void Start()
    {
        Fire rate = 1f;
        next fire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();  
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
