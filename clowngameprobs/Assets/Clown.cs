using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clown : MonoBehaviour
{   
    [SerializeField] float move = 5f;
    [SerializeField] Rigidbody2D rbd;
    Vector2 movement;
    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //input here
        movement.x = Input.GetAxisRaw("Horizontal"); //wasd or arrows
        movement.y = Input.GetAxisRaw("Vertical"); //wasd or arrows
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        //movement here
        rbd.MovePosition(rbd.position + movement * move);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("circus"))
        {
            SceneManager.LoadScene(1);

        }
    }
}
