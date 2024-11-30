using UnityEngine;

public class ColdWeapons : MonoBehaviour
{
    [SerializeField] 
    private float _rotationOffset = 90;
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + _rotationOffset);

        Vector3 LocalSalle = Vector3.one;

        if(angle > 90 || angle < 90)
        {
            LocalSalle.y = -1f;
        }
        else
        {
            LocalSalle.y = 1f;
        }

        transform.localScale = LocalSalle;
    }
}
