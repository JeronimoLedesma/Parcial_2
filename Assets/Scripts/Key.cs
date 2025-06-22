using UnityEngine;

public class Key : MonoBehaviour, Iinteractuable
{
    public void Interactuar()
    {
        Debug.Log("Obtuviste Llave");
        GameManager.hasKey = true;
        Destroy(gameObject);
    }
}
