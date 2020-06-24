
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if(collisionInfo.collider.tag == "Ground")
        {
            movement.CanJump = true;
        }
        if(collisionInfo.collider.tag == "Water")
        {
            movement.Swimming = true;
        }
        if(collisionInfo.collider.tag == "Wall")
        {
            movement.PlayerDirection.rotation = new Quaternion(0f,0f,0f,0f);
            movement.rb.velocity = new Vector3(0f,0f,0f);
            movement.rb.useGravity = false;
            movement.CanClimb = true;
        }
    }

    void OnCollisionExit (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Ground")
        {
            movement.CanJump = false;
        }
        if(collisionInfo.collider.tag == "Wall")
        {
            movement.rb.useGravity = true;
            movement.CanClimb = false;
        }
        if(collisionInfo.collider.tag == "Water")
        {
            movement.Swimming = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
