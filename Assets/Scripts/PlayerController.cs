using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5;
    [SerializeField] private float radio;
    [SerializeField] private LayerMask interact;
    private Vector2 startingPosition;
    //Al inicio establece cual era la posicion inicial, para enviarlo ahi en caso de ser golpeado
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;
    }

    
    void Update()
    {
        Caminar();

        //Interactua con el objeto interactuable mas cercano en un radio establecido
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
        //Devuelve al jugador a la posicion inicial al ser golpeado
        if (collision.collider.CompareTag("Enemy"))
        {
            transform.position = startingPosition;
        }
    }
}
