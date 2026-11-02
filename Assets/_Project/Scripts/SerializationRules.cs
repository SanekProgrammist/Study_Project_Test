using UnityEngine;

public class SerializationRules : MonoBehaviour
{
    // Будут показаны в Inspector:
    public int PublicInt = 10;
    public float PublicFloat = 5.5f;
    public string PublicString = "Hello";
    public GameObject PublicGameObject;

    [SerializeField]
    private int _serializedPrivate = 20;

    // НЕ будут показаны в Inspector:
    private int _privateInt = 30;
    public static int StaticVariable = 100;
}
