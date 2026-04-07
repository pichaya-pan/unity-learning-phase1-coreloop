using UnityEngine;

public class TransformProbe : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Object Name: " + gameObject.name);
        Debug.Log("Position: " + transform.position);
        Debug.Log("Rotation: " + transform.rotation);

        transform.position = new Vector3(0f, 10f, -10f);
    }
}
