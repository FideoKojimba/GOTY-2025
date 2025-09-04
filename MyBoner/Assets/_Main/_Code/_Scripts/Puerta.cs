using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    [SerializeField]
<<<<<<< Updated upstream
    private GameManager gameManager;
=======
    private GameManager GameManager;
>>>>>>> Stashed changes


    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< Updated upstream
        if (collision.gameObject.tag == "Player" & gameManager.llaveObtenida ==true)
        {
            gameManager.puertaAbierta = true;
            gameManager.FinJuego();
            Debug.Log("Puerta");
=======
        if (collision.gameObject.tag == "Player" & GameManager.llaveObtenida ==true)
        {
            GameManager.puertaAbierta = true;
            
>>>>>>> Stashed changes
        }
    }
}
