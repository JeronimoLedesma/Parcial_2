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
    public abstract void RecibirDaño(int daño);
    public void Interactuar()
    {
        Debug.Log("Enemigo Recibio daño");
        RecibirDaño(5);
    }
}
