using UnityEngine;
using TMPro;
public class UI : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [Header("Referencias a TextMeshPro")]
    [SerializeField]
    private TMP_Text textoVida;
    [SerializeField]
    private TMP_Text textoTiempo;
    [SerializeField]
    private TMP_Text textoPuntos;
    [SerializeField]
    private TMP_Text textoLlave;

    private bool tienellave = false;

    private void Update()
    {
        if (gameManager != null)
        {
            textoVida.text = "Vida: " + gameManager.Vida;
            textoTiempo.text = "Tiempo: " + Mathf.CeilToInt(gameManager.Tiempo);
            textoPuntos.text = "Puntos: " + gameManager.Puntos;
            textoLlave.text = "Llave: " + (tienellave ? "Sí" : "No");
        }
    }
    public void ActivarLlave()
    {
        tienellave = true;
    }
}
