using UnityEngine;

public class Door : MonoBehaviour, Iinteractuable
{
    public GameObject spawnKeyPoint;
    public GameObject key;
    private bool keyExists = false;
    public void Interactuar()
    {
        //Comprueba que el jugador tenga una llave, destruyendo la puerta si la tiene
        if (GameManager.hasKey)
        {
            Debug.Log("Se abrio");
            Destroy(gameObject);
        }
        else
        {
            //si el jugador no tiene la llave, comprueba si no ha creado ya la llave para que el jugador busque y emite un mensaje en todos los casos
            if (!keyExists)
            {
                GameObject theKey = Instantiate(key);
                theKey.transform.position = spawnKeyPoint.transform.position;
                keyExists = true;
            }
            Debug.Log("No pudo abrirse, busca la llave, de brillo dorado");
        }
    }
}
