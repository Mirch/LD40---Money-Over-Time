using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character {

    public class PlayerMovement : MonoBehaviour
    {

        public float Speed = 1.0f;

        private float MovingFactor;


        void Start()
        {
            MovingFactor = Speed / 10.0f;
        }

        void Update()
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            float moveForward = Input.GetAxis("Vertical");
            float moveSideways = Input.GetAxis("Horizontal");

            transform.Translate(moveSideways * MovingFactor, 0, moveForward * MovingFactor);

        }
    }
}