using UnityEngine;
using UnityEngine.SceneManagement;
public class MuslitoVida : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.SumarVida(1);

            Destroy(this.gameObject);
        }
    }
}
