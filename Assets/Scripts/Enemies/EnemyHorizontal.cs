using UnityEngine;

public class EnemyHorizontal : Enemy
{
    bool derecha;
    private void Awake()
    {
        derecha = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        if (derecha)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }

        if (transform.position.x >= limit)
        {
            derecha = false;
        }
        if (transform.position.x <= limitInferior)
        {
            derecha = true;
        }

    }

    public override void RecibirDaño(int daño)
    {
        life -= daño;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
