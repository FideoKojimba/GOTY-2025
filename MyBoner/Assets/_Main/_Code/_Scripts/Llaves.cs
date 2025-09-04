using UnityEngine;
using UnityEngine.SceneManagement;
public class Llaves : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.llaveObtenida = true;
            Debug.Log("Tengo la llave");
            Destroy(this.gameObject);
        }
    }

  
}
