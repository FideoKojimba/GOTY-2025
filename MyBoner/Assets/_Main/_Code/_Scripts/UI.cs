using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.ShaderKeywordFilter;
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
    [SerializeField]
    private GameObject[] gameObjectsHeart;
    [SerializeField]
    private Image[] spritesBTDHeart;




    private void Update()
    {
        if (gameManager != null)
        {
            textoVida.text = "Vida: " + gameManager.Vida;
            textoTiempo.text = "Tiempo: " + Mathf.CeilToInt(gameManager.Tiempo);
            textoPuntos.text = "Puntos: " + gameManager.Puntos;
            textoLlave.text = "Llave: " + (gameManager.llaveObtenida ? "S�" : "No");
        }
        for (int i = gameManager.Vida; i < 5; i++)
        {
            spritesHeart[i].enabled = false;



            if (i == 0)
            {
                gameObjectsHeart[0].SetActive(false);
                gameObjectsHeart[1].SetActive(false);
                gameObjectsHeart[2].SetActive(false);
                gameObjectsHeart[3].SetActive(false);
                gameObjectsHeart[4].SetActive(false);
            }
            if (i == 1)
            {
                gameObjectsHeart[0].SetActive(true);
                gameObjectsHeart[1].SetActive(false);
                gameObjectsHeart[2].SetActive(false);
                gameObjectsHeart[3].SetActive(false);
                gameObjectsHeart[4].SetActive(false);

            }
            if (i == 2)
            {
                gameObjectsHeart[0].SetActive(true);
                gameObjectsHeart[1].SetActive(true);
                gameObjectsHeart[2].SetActive(false);
                gameObjectsHeart[3].SetActive(false);
                gameObjectsHeart[4].SetActive(false);
            }
            if (i == 3)
            {
                gameObjectsHeart[0].SetActive(true);
                gameObjectsHeart[1].SetActive(true);
                gameObjectsHeart[2].SetActive(true);
                gameObjectsHeart[3].SetActive(false);
                gameObjectsHeart[4].SetActive(false);
            }
            if (i == 4)
            {
                gameObjectsHeart[0].SetActive(true);
                gameObjectsHeart[1].SetActive(true);
                gameObjectsHeart[2].SetActive(true);
                gameObjectsHeart[3].SetActive(true);
                gameObjectsHeart[4].SetActive(false);
            }
            if (i == 5)
            {
                gameObjectsHeart[0].SetActive(true);
                gameObjectsHeart[1].SetActive(true);
                gameObjectsHeart[2].SetActive(true);
                gameObjectsHeart[3].SetActive(true);
                gameObjectsHeart[4].SetActive(true);
            }
        }
        

    }
}


 
        
         
