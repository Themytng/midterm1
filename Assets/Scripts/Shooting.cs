using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform BulletPos;

    private float timer;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position); //tracks the distance of the bullet
        Debug.Log(distance);
        timer += Time.deltaTime;

       if (distance > 7)
        {
            if (timer > 1.5)
            {
                shoot(); //when distance is more than 7, switch to stream-type fire
            }
        }

       else if(timer > 2)
        {
            timer = 0;
            shoot(); //passive bullets every 2 seconds
        }
    }

    void shoot()
    {
        Instantiate(bullet, BulletPos.position, Quaternion.identity); //actually fires the prefab bullet
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("BOOOM.");
        }
    }
    
}
