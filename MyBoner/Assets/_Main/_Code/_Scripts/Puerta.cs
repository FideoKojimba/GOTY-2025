using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" & gameManager.llaveObtenida ==true)
        {
            gameManager.puertaAbierta = true;
            gameManager.FinJuego();
            Debug.Log("Puerta");
        }
    }
}
