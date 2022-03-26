using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Script Dedicado al movimiento del personaje
    
    //Input del movimiento
    public float horizontalInput;
    //float verticalInput;
    [SerializeField]
    public float movimiento = 5.0f;
    [SerializeField]
    public float jumpAmount = 5.0f;

    bool isJumping = false;

    public enum PlayerState
    {
        Normal,
        Jumping,
        Death
    }

    public Rigidbody2D rb;
    
    //Vidas del personaje
    [SerializeField]
    private int lives = 3;
    
    //Seccion de PowerUp
    public bool shoot;
    public bool armor;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(horizontalInput);
        transform.Translate(Vector3.right * movimiento * horizontalInput * Time.deltaTime);

        
            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
                isJumping = true;
            }

        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "World")
        {
            isJumping = false;
        }
    }
}
