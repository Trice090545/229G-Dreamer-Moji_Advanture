using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer
{
    public class PlayerDeathState : MonoBehaviour
    {
        public float jumpForce;

        private Rigidbody2D rigibody;
        void Start()
        {
            rigibody = GetComponent<Rigidbody2D>();
            rigibody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}

