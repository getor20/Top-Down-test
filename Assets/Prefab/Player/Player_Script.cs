using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Script : MonoBehaviour
{
    private Player_Animator_Scripts player_Animator_Scripts => GetComponent<Player_Animator_Scripts>();
    private Rigidbody2D rd2D => GetComponent<Rigidbody2D>();
    private Vector2 vector2 = Vector2.zero;

    [SerializeField]
    private float speed = 10f;  

    private bool Flip = false;

    public bool IsMove = false;

    private void FixedUpdate()
    {
        rd2D.velocity = new Vector2(vector2.x * speed, vector2.y * speed);
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            IsMove = true;
        }
        else if (context.canceled)
        {
            IsMove = false;
        }

        vector2 = context.ReadValue<Vector2>();

        if (vector2.x != 0 && !Flip)
        {
            player_Animator_Scripts.Flip(vector2.x);
        }
    }
}
