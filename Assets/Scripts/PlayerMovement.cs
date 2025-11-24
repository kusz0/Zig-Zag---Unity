using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform rayStart;

    Rigidbody rb;
    private bool isWalkingRight = true;
    private Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

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

        RaycastHit hit;
        if(!Physics.Raycast(rayStart.position, -transform.up, out hit, Mathf.Infinity))
        {
            anim.SetTrigger("isFalling");
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
