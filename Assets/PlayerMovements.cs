using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 800f; 
    public float sidewayForce = 300f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        
        if(Input.GetKey(KeyCode.D)) {
            rb.AddForce(sidewayForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.A)) {
            rb.AddForce(-sidewayForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
