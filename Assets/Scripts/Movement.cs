using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float rotation = 10f;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        Move();
        Rotate();
        ChangeColor(spriteRenderer);
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * (speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.down * (speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * (speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }
    
    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            transform.rotation  *= Quaternion.Euler(0f, 0f, rotation);
        if (Input.GetKeyDown(KeyCode.E))
            transform.rotation  *= Quaternion.Euler(0f, 0f, -rotation);
    }
    void ChangeColor(SpriteRenderer sr)
    {
       float r = Random.value;
       float g = Random.value;
       float b = Random.value;
       if (Input.GetKeyUp(KeyCode.R))
            sr.color = new Color(r,g, b, 255f);
            
            
    }
}
