using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position; //aim for the player/ship
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force; //fire the bullet 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3)
        {
            Destroy(gameObject); //destroys the bullet sprite after 3 seconds
        }
    }

    void OnTriggerEnter2D(Collider2D other) //destroys object that hit and loads a new scene
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

            SceneManager.LoadScene("New Scene");
        }
    }
}




