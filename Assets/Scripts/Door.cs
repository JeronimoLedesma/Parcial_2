using UnityEngine;

public class Door : MonoBehaviour, Iinteractuable
{
    public void Interactuar()
    {
        if (GameManager.hasKey)
        {
            Debug.Log("Se abrio");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("No pudo abrirse, busca la llave, de brillo dorado");
        }
    }
}
