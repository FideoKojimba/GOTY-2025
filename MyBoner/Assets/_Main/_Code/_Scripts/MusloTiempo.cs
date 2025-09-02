using UnityEngine;

public class MusloTiempo : MonoBehaviour
{
    [SerializeField]
    private float _tiempoExtra = 10f;
    [SerializeField]
    GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            gameManager.SumarTiempo(_tiempoExtra);
            Destroy(this.gameObject);
        }
    }
}
