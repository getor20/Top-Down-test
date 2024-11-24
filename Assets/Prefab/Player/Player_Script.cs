using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Script : MonoBehaviour
{
    private Rigidbody2D rd2D => GetComponent<Rigidbody2D>();
    private Vector2 vector2 = Vector2.zero;

    [SerializeField]
    private float speed = 10f;

    private bool _isFacingRight = true;

    public bool IsFacingRight
    {
        get
        {
            return _isFacingRight;
        }
        private set
        {
            if (_isFacingRight != value)
            {
                transform.localScale *= new Vector2(-1  , 1);
            }

            _isFacingRight = value;
        }
    }

    private void FixedUpdate()
    {
        rd2D.velocity = new Vector2(vector2.x * speed, vector2.y * speed);
    }

    public void Move(InputAction.CallbackContext context)
    {
        vector2 = context.ReadValue<Vector2>();

        SetFacingDirection(vector2);
    }

    private void SetFacingDirection(Vector2 direction)
    {
        if (direction.x > 0 && !IsFacingRight)
        {
            IsFacingRight = true;   
        }
        else if (direction.x < 0 && IsFacingRight)
        {
            IsFacingRight = false;
        }
    }
}
