using UnityEngine;

public abstract class Enemy : MonoBehaviour, Iinteractuable
{
    [SerializeField] protected ScriptableEnemy data;
    protected float life;
    protected float speed;
    protected string nombre;
    protected float limit;
    protected float limitInferior;

    protected void Start()
    {
        life = data.Vida;
        speed = data.Velocidad;
        nombre = data.Nombre;
        limit = data.Limite;
        limitInferior = data.LimiteInferior;
    }


    public abstract void Move();

    //Es publico para poder ser utilizado por el jugador al ser la funcion interactuable
    public void Interactuar()
    {
        Debug.Log("Enemigo Recibio daño");
        RecibirDaño(5);
    }

    //Es protegido para poder ser heredado sin problema
    protected void RecibirDaño(int daño)
    {
     life -= daño;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
