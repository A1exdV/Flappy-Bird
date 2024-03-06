using System;
using UnityEngine;

namespace Game.Player
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float jumpForce = 22f;
        private Rigidbody2D rb2D;

        private void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            GetInput();
        }


        private void GetInput()
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                Jump();
            }
        }

        private void Jump()
        {
            rb2D.velocity = Vector2.up*jumpForce;
        }
        
        
    }
}
