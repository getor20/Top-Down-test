using Assets.Prefab.Weapons.ColdWeapons.Sword1;
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
    private Animator _animator => GetComponent<Animator>();

    void Update()   
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector3 direction = mousePos - transform.position;
        direction.Normalize();
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - _rotationOffset, Vector3.forward);
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
    public void Attack(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            _animator.SetTrigger(Sword1AnimationStrings.Attacks);
        }
    }
}
