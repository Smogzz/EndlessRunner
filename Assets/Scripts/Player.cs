using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRB;
    [SerializeField] float jumpForce;
    public bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(new Vector2(0,1) * jumpForce, ForceMode2D.Impulse);
            Debug.Log("space key was pressed");
        }
    }
}
