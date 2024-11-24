using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Script : MonoBehaviour
{
    private Rigidbody2D rd2D;
    private Vector2 vector2 = Vector2.zero;

    [SerializeField]
    private float speed = 10f;

    private void Awake()
    {
        rd2D = GetComponent<Rigidbody2D>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        vector2 = context.ReadValue<Vector2>();
    }
}
