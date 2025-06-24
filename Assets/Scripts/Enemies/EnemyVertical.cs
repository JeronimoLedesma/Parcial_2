using UnityEngine;

public class EnemyVertical : Enemy
{
    bool arriba;
    private void Awake()
    {
        arriba = true;
    }

    
    void Update()
    {
        Move();
    }

    //Define un movimiento vertical de arriba a abajo con 2 limites en donde se da la vuelta
    public override void Move()
    {
        if (arriba)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }

        if (transform.position.y >= limit)
        {
            arriba = false;
        }
        if (transform.position.y <= limitInferior)
        {
            arriba = true;
        }

    }
}
