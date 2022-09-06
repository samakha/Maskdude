
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EasyJoystick; 
public class Playercontroller : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float forceJUmp;
    public Joystick joystick;
    Rigidbody2D rb;
    Vector2 moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = joystick.Horizontal();
        rb.MovePosition(rb.position + moveInput * Time.deltaTime * moveSpeed);


        jump();


    }
    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * forceJUmp;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RedO")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

}