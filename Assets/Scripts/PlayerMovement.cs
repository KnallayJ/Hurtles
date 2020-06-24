
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float ForwardsForce;
    public float SidewaysForce;
    public float ClimbForce;
    public float JumpForce;
    public float SwimForce;
    public float FlightForce;
    // public CharacterSelector CurrentPlayer;
    public Rigidbody rb;
    public Transform PlayerDirection;
    public bool CanJump;
    public bool CanClimb;
    public bool Flying;
    public bool Swimming;
    // Start is called before the first frame update
    void Start()
    {
        float SpeedMultiplier = PlayerPrefs.GetFloat("Speed");
        float JumpMultiplier = PlayerPrefs.GetFloat("JumpHeight");
        float ClimbMultiplier = PlayerPrefs.GetFloat("ClimbSpeed");
        float SwimMultiplier = PlayerPrefs.GetFloat("SwimSpeed");
        float FlightMultiplier = PlayerPrefs.GetFloat("FlightSpeed");
        // If you're not using the main menu, have this next part commented out:
        ForwardsForce = 2000f*SpeedMultiplier;
        SidewaysForce = 125f*SpeedMultiplier;
        ClimbForce = 2000f*ClimbMultiplier;
        JumpForce = 40000f*JumpMultiplier;
        SwimForce = 2000f*SwimMultiplier;
        FlightForce = 1000f*FlightMultiplier;
        // If you're not using the main menu, have the part above commented out

        // If you're using the main menu, comment out the next part:
        // ForwardsForce = 2000f;
        // SidewaysForce = 125f;
        // ClimbForce = 2000f;
        // JumpForce = 40000f;
        // SwimForce = 2000f;
        // FlightForce = 0;
        // If you're using the main menu have the above part commented out
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
            Debug.Log(ForwardsForce);
            Debug.Log(SwimForce);
            if(Swimming == true)
            {
                Debug.Log($"You're swimming! Your Swim Multiplier is {SwimForce}");
                rb.AddForce(0, 0, SwimForce * Time.deltaTime);
            }
            // else if(Flying == true)
            // {
            //     rb.AddForce(0, 0, FlightForce * Time.deltaTime);
            // }
            else
            {
                Debug.Log($"You're walking! Your Walk Multiplier is {ForwardsForce}");
                rb.AddForce(0, 0, ForwardsForce * Time.deltaTime);
            }
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
            if(Swimming == true)
            {
                rb.AddForce(0, 0, -SwimForce * Time.deltaTime);
            }
            // else if(Flying == true)
            // {
            //     rb.AddForce(0, 0, FlightForce * Time.deltaTime);
            // }
            else
            {
                rb.AddForce(0, 0, -ForwardsForce * Time.deltaTime);
            }
        }
        if(Input.GetKey("space") && CanJump == true)
        {
            rb.AddForce(0, JumpForce * Time.deltaTime, 0);
        }
        if(rb.position.y < .8)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
