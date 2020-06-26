using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;
    public Transform cam;
    public float speed = 600f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded)
        {
            Debug.Log("Character is grounded");
        }
        else
        {
            Debug.Log("Character is not grounded");
        }
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 MoveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.SimpleMove(MoveDirection.normalized * speed * Time.deltaTime);
        }
        
    }
}
