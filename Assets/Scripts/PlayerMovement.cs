using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform rayStart;

    Rigidbody rb;
    private bool isWalkingRight = true;
    private Animator anim;
    private GameManager gameManager;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        gameManager = FindFirstObjectByType<GameManager>();
    }
    private void FixedUpdate()
    {
        if(!gameManager.isGameStarted)
        {
            return;
        }else
        {
            anim.SetTrigger("isStarted");
        }

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
        if(transform.position.y < -5f)
        {
            gameManager.EndGame();
        }


    }
    private void Switch()
    {
            isWalkingRight = !isWalkingRight;
            if(isWalkingRight)
            {
                transform.rotation = Quaternion.Euler(0,45,0);
            }else
            {
                transform.rotation = Quaternion.Euler(0,-45,0);
        }
    }


}
