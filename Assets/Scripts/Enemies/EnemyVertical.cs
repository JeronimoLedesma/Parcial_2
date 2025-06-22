using UnityEngine;

public class EnemyVertical : Enemy
{
    bool arriba;
    private void Awake()
    {
        arriba = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

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

    public override void RecibirDa�o(int da�o)
    {
        life -= da�o;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
