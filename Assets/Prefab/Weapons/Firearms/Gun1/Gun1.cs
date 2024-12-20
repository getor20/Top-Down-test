using UnityEngine;
using UnityEngine.InputSystem;

public class Gun1 : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform bulletTransform;

    void Update()
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector3 direction = mousePos - transform.position;
        direction.Normalize();
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.position = player.transform.position;

        Vector3 LocalScale = Vector3.one;

        if (angle > 90 || angle < -90)
        {
            LocalScale.y = -1f;
        }
        else
        {
            LocalScale.y = +1f;
        }

        transform.localScale = LocalScale;
    }

    public void Fire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Instantiate(bullet, bulletTransform.position, transform.rotation);
        }
    }
}
