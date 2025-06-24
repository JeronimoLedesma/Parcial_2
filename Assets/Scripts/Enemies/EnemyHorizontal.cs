using UnityEngine;

public class EnemyHorizontal : Enemy
{
    bool derecha;
    private void Awake()
    {
        derecha = true;
    }

    void Update()
    {
        Move();
    }

    //Define un movimiento horizontal con 2 limites donde se da la vuelta
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
}
