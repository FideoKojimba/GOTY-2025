using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int _puntos = 0;

    [SerializeField]
    private int _vida = 10;
    [SerializeField]
    private float _tiempoRestante = 60f;
    [SerializeField]
    private int _tiempoentero;
    [SerializeField]
    private bool juegoActivo = true;
    
    public bool llaveObtenida = false;

    public bool puertaAbierta = false;

    public void Update()
    {
        if (juegoActivo)
        {
            _tiempoRestante -= Time.deltaTime;

            if (_tiempoRestante <= 0)
            {
                juegoActivo = false;
                Debug.Log("Se acabó el tiempo");
                
            }
        }

        if (_tiempoRestante > 0)
        {
            _tiempoentero = (int)_tiempoRestante;
            _tiempoRestante -= Time.deltaTime;

            Debug.Log("tiempo restante: " + Mathf.CeilToInt(_tiempoentero));

        }
        if (_tiempoRestante <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void SumarTiempo(float cantidad)
    {
        _tiempoRestante += cantidad;
        Debug.Log("Tiempo aumentado: " + _tiempoRestante);
    }

    public void SumarPuntos(int cantidad)
    {
        _puntos += cantidad;
        Debug.Log("Puntos actuales: " + _puntos);
    }

    public void SumarVida(int cantidad)
    {
        _vida += cantidad;
        Debug.Log("Vidas Actuales: " + _vida);
    }
    public void RestarVida(int cantidad)
    {
        Debug.Log(_vida);
        _vida -= cantidad;
        if (_vida <= 0)
        {
            Debug.Log("El jugador ha muerto, reiniciando escena...");
            SceneManager.LoadScene(2);
        }
       
    }

    public void FinJuego()
    {
        if (puertaAbierta == true)
        {
            Debug.Log("Juego Terminado");
            SceneManager.LoadScene(3);
        }
    }

    public int Puntos
    {
        get { return _puntos; }
    }
    public int Vida
    {
        get { return _vida; }
    }

<<<<<<< Updated upstream
    public float Tiempo
    {
        get { return _tiempoRestante; }
    }
=======
    
    
        

>>>>>>> Stashed changes
}
