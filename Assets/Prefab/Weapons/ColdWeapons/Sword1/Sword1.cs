using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sword1 : MonoBehaviour
{
    [SerializeField] 
    private float _rotationOffset = 90f;
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private GameObject player;

    public bool Attacks = false;
    private float timer;
    void Update()   
    {
        timer += Time.deltaTime;
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector3 direction = mousePos - transform.position;
        direction.Normalize();
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - _rotationOffset, Vector3.forward);
        transform.position = player.transform.position;
    }
    public void Attack(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Attacks = true;
        }
        else if (context.canceled)
        {
            
            

        }
    }
}
