using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    //variables for movement
    public float speed = 10f;
    public float yBorder = 5f;
    public float xBorder = 7f;

    public Rigidbody2D rb;

    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime; //lines of code meant to get the ship moving with the arrow keys; a lot of trial and error came here
        rb.MovePosition(rb.transform.position + tempVect);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle")
        {
            SceneManager.LoadScene("BOOOM.");
        }
    }
}

