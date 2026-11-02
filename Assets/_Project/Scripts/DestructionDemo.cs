using UnityEngine;

public class DestructionDemo : MonoBehaviour
{
    void OnDisable()
    {
        Debug.Log("OnDisable: Объект деактивирован");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy: Объект уничтожается");
    }
}
