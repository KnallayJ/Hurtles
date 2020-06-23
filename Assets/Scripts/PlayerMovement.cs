
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float ForwardsForce;
    public float SidewaysForce = 500f;
    public float ClimbForce;
    public float JumpForce;
    // public CharacterSelector CurrentPlayer;
    public Rigidbody rb;
    public Transform PlayerDirection;
    public bool CanJump;
    public bool CanClimb;
    // Start is called before the first frame update
    void Start()
    {
        float SpeedMultiplier = PlayerPrefs.GetFloat("Speed");
        float JumpMultiplier = PlayerPrefs.GetFloat("JumpHeight");
        float ClimbMultiplier = PlayerPrefs.GetFloat("ClimbSpeed");
        // ForwardsForce = 2000f*SpeedMultiplier;
        // ClimbForce = 2000f*ClimbMultiplier;
        // JumpForce = 40000f*JumpMultiplier;
        ForwardsForce = 2000f;
        ClimbForce = 2000f;
        JumpForce = 40000f;
        Debug.Log($"Run multiplier:{SpeedMultiplier} Climb multiplier:{ClimbMultiplier} Jump Multiplier:{JumpMultiplier}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && CanJump == true)
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a") && CanJump == true)
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, ForwardsForce * Time.deltaTime);
        }
        if(Input.GetKey("e") && CanClimb == true)
        {
            rb.AddForce(0, ClimbForce * Time.deltaTime, 0);
        }
        if(Input.GetKey("c") && CanClimb == true)
        {
            rb.AddForce(0, -ClimbForce * Time.deltaTime, 0);
        }
        if(Input.GetKey("s") && CanJump == true)
        {
            rb.AddForce(0, 0, -ForwardsForce * Time.deltaTime);
        }
        if(Input.GetKey("space") && CanJump == true)
        {
            Debug.Log(JumpForce);
            rb.AddForce(0, JumpForce * Time.deltaTime, 0);
        }
        if(rb.position.y < .8)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
