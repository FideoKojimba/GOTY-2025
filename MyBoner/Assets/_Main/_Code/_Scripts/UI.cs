using UnityEngine;
using TMPro;
using UnityEngine.UI;
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
    [SerializeField]
    private Image[] spritesHeart;





    private void Update()
    {
        if (gameManager != null)
        {
            textoVida.text = "Vida: " + gameManager.Vida;
            textoTiempo.text = "Tiempo: " + Mathf.CeilToInt(gameManager.Tiempo);
            textoPuntos.text = "Puntos: " + gameManager.Puntos;
            textoLlave.text = "Llave: " + (gameManager.llaveObtenida ? "Sí" : "No");
        }
        for (int i = 0; i < 4; i++)
        {
            spritesHeart[i].enabled = false;
        }

    }
  
}
