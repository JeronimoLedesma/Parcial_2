using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5;
    [SerializeField] private float radio;
    [SerializeField] private LayerMask interact;
    private Vector2 startingPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Caminar();
        if (Input.GetKeyDown(KeyCode.K))
        {
            Collider2D collider = Physics2D.OverlapCircle(transform.position, radio, interact);
            if (collider.GetComponent<Iinteractuable>() != null)
            {
                collider.GetComponent<Iinteractuable>().Interactuar();
            }
        }
    }

    void Caminar()
    {
        var movimiento = Input.GetAxisRaw("Horizontal");
        var movimientoY = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector2(movimiento * speed, movimientoY * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            transform.position = startingPosition;
        }
    }
}
