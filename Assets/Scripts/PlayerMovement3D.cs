using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public float speed = 5f;
    public float currentSpeed;

    
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0f, 1f, 0f);
        }
    }
}
