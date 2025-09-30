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
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            EstadodelJuego("Pause");
        }
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
            EstadodelJuego("Perdiste");
        }
       
    }

    public void FinJuego()
    {
        if (puertaAbierta == true)
        {
            Debug.Log("Juego Terminado");
            EstadodelJuego("Ganaste");
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

    public float Tiempo
    {
        get { return _tiempoRestante; }
    }
    public void EstadodelJuego(string estado)
    {
        switch (estado)
        {
            case "Play":
                Time.timeScale = 1;
                break;

            case "Pause":
                Time.timeScale = 0;
                break;

            case "Ganaste":
                SceneManager.LoadScene(2);
                break;

            case "Perdiste":
                SceneManager.LoadScene(3);
                break;
            case "Salir":
                Application.Quit();
                break;
        }
    }
    
}


