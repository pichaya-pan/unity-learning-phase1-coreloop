using UnityEngine;


public class PlayerMovement2D : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, 1f, 0f) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1f, 0f, 0f) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, -1f, 0f) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1f, 0f, 0f) * speed * Time.deltaTime;
        }



    }


 

}
