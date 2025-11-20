using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private bool isWalkingRight = true;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;

    }


    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Switch();
        }
    }
    private void Switch()
    {
        isWalkingRight = !isWalkingRight;

        if(isWalkingRight )
        {
            transform.rotation = Quaternion.Euler(0,45,0);
        }else
        {
            transform.rotation = Quaternion.Euler(0,-45,0);
        }
    }


}
