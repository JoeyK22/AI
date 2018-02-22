using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoingHome
{
    public class Player : MonoBehaviour
    {
        public float movementSpeed = 20f;

        private Rigidbody rigid;
        private Transform cam;

        void Start()
        {
            rigid = GetComponent<Rigidbody>();

            cam = Camera.main.transform;

        }
        void Movement()
        {
            float InputH = Input.GetAxis("Horizontal");
            float InputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(InputH, 0, InputV);
            inputDir = Camera.main.transform.TransformDirection(inputDir);

            rigid.AddForce(inputDir * movementSpeed);

        }

        void Update()
        {
            Movement();
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            inputDir = Quaternion.AngleAxis(cam.eulerAngles.y, Vector3.up) * inputDir;

            // Moves the position of the rigidbody without 
            // effecting gravity
            Vector3 position = transform.position;
            position += inputDir * movementSpeed * Time.deltaTime;
            rigid.MovePosition(position);

        }


    }
}
