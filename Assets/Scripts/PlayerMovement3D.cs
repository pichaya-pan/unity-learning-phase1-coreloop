using UnityEngine;
using System.Collections;

public class PlayerMovement3D : MonoBehaviour
{
    public float speed = 7f;    // Balance speed
    public float currentSpeed;
    private bool isJumping = false;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position += new Vector3(0f, 0f, 1f) * currentSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1f, 0f, 0f) * currentSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, 0f, -1f) * currentSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1f, 0f, 0f) * currentSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = speed * 2f;

        }
        else
        {
            currentSpeed = speed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            /*
             * transform.position += new Vector3(0f, 1f, 0f);
             * transform.position += new Vector3(0f, -1f, 0f);
             */

            StartCoroutine(JumpRoutine());
        }
    }


    IEnumerator JumpRoutine()
    {
        isJumping = true;
        
        // up
        transform.position += new Vector3(0f, 1f, 0f);

        // wait
        yield return new WaitForSeconds(0.15f);

        // down
        transform.position += new Vector3(0f, -1f, 0f);

        isJumping = false;
    }

}
