using UnityEngine;

public class BulletsGun1 : MonoBehaviour
{
    Rigidbody2D rd2D => GetComponent<Rigidbody2D>();
    [SerializeField]
    public float speed = 10;

    private void Start()
    {
        rd2D.velocity = transform.right * speed;
    }

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
    }
}
