using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float speed = 10;
    public float playerHealth;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var input = Input.GetAxis("Horizontal");
        var input2 = Input.GetAxis("Vertical");   
        
        Vector2 position = transform.position;
        position.x += speed * Time.deltaTime * input;
        position.y += speed * Time.deltaTime * input2;
       
        transform.position = position;
       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Flag")
        {
            SceneManager.LoadScene("WinLevel");
        }

        if (collision.tag == "projectile")
        {
            SceneManager.LoadScene("EndLevel");
        }


    }
}
