using UnityEngine;

public class LifecycleDemo : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake: Объект создан");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable: Объект активирован");
    }

    void Start()
    {
        Debug.Log("Start: Готов к работе");
    }
}
