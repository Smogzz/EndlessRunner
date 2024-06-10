using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRB;
    [SerializeField] float jumpForce;
    public bool isAlive;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            playerRB.AddForce(new Vector2(0,1) * jumpForce, ForceMode2D.Impulse);
            canJump = false;
            Debug.Log("space key was pressed");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            canJump = true;
        }
    }
}
