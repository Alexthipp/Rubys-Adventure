using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubysController : MonoBehaviour
{
    public int maxHealth = 5;
    int currentHealth;

    public float Speed = 3.0f;

    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = rigidbody2d.position;
        position.x = position.x + Speed * horizontal * Time.deltaTime;
        position.y = position.y + Speed * vertical * Time.deltaTime;
        
        rigidbody2d.MovePosition(position);
    }

    void ChangeHealth(int amount){
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" +maxHealth);
    }
}
