using UnityEngine;

public class ObstaCULO : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private int _puntosNecesarios = 10;


    private void Update()
    {
        if (gameManager.Puntos >= _puntosNecesarios)
        {
            Destroy(this.gameObject);
        }
    }
}
