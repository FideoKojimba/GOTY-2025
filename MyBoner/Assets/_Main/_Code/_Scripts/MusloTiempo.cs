using UnityEngine;

public class MusloTiempo : MonoBehaviour
{
    [SerializeField]
    private float _tiempoExtra = 5f;
    [SerializeField]
    GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.SumarTiempo(_tiempoExtra);
            Destroy(gameObject);
        }
    }
}
