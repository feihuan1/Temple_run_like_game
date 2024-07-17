using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f; 
    public float sidewayForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        
        if(Input.GetKey(KeyCode.D)) {
            rb.AddForce(sidewayForce*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.A)) {
            rb.AddForce(-sidewayForce*Time.deltaTime, 0, 0);
        }
    }
}
