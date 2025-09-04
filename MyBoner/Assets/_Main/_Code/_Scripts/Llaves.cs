using UnityEngine;
<<<<<<< Updated upstream
using UnityEngine.SceneManagement;
public class Llaves : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
=======

public class Llaves : MonoBehaviour
{
    [SerializeField]
    private GameManager GameManager;
>>>>>>> Stashed changes
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
<<<<<<< Updated upstream
            gameManager.llaveObtenida = true;
=======
            GameManager.llaveObtenida = true;
>>>>>>> Stashed changes
            Debug.Log("Tengo la llave");
            Destroy(this.gameObject);
        }
    }

  
}
