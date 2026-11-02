using UnityEngine;

public class UpdateDemo : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Update");
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
}
