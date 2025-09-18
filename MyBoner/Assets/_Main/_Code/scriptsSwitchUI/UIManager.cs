using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text tituloText;
    [SerializeField]
    private TMP_Text alertaText;

    [SerializeField]
    private TMP_InputField respuestaInput;

    [SerializeField]
    private Button enviarButton;

    [SerializeField]
    private int edad;

    private void Start()
    {
        tituloText.text = "Hola, introduce tu edad. ";
        alertaText.text = "";
        enviarButton.onClick.AddListener(FuncionDelBoton);
    }

    public void FuncionDelBoton()
    {
        edad = int.Parse(respuestaInput.textComponent.text);
    }
}
