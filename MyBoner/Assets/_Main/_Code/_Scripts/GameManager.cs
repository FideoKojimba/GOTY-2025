using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int _puntos;

    [SerializeField]
    private int _vida = 10;

    public void SumarPuntos(int cantidad)
    {
        _puntos += cantidad;
        Debug.Log("Puntos actuales: " + _puntos);
    }

    public void RestarVida(int cantidad)
    {
        if (_vida <= 0)
        {
            Debug.Log("El jugador ha muerto, reiniciando escena...");
            SceneManager.LoadScene(1);
        }
       
    }
}
