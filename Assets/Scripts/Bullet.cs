using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D rb;

    Ship target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        target = GameObject.FindObjectOfType<Ship> ();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
            
    }

    void OnTriggerCollision2D (Collision2D collision) //trigger the game over
    {
        Debug.Log("hit");
        if (tag == "Respawn")
        {
            SceneManager.LoadScene("New Scene");
        }
    }
}
