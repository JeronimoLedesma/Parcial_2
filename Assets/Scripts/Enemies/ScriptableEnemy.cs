using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableEnemy", menuName = "Enemigo")]
public class ScriptableEnemy : ScriptableObject
{
    //Determina las caracteristicas que pueden tener lso enemigos
    [SerializeField] private string nombre;
    [SerializeField] private float vida;
    [SerializeField] private float velocidad;
    [SerializeField] private float limite;
    [SerializeField] private float limiteInferior;

    public string Nombre { get { return nombre; } }
    public float Vida { get { return vida; } }
    public float Limite { get { return limite; } }
    public float Velocidad { get { return velocidad; } }
    public float LimiteInferior { get { return limiteInferior; } }
}
