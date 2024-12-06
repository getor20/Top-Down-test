using UnityEngine;
using UnityEngine.InputSystem;

public class ColdWeapons : MonoBehaviour
{
    [SerializeField] 
    private float _rotationOffset = 90f;
    [SerializeField]
    private Camera mainCamera;
    void Update()   
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector3 direction = mousePos - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - _rotationOffset, Vector3.forward);
    }

    public void Attacks(InputAction.CallbackContext context)
    {

    }
}
