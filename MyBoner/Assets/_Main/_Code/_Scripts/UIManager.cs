using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]   
    private TMP_Text tituloText;
    [SerializeField]
    private TMP_Text alertasText;

    [SerializeField]
    private TMP_Text respuestaInput;

    [SerializeField]
    private Button enviarButton;

    [SerializeField]
    private int edad;

    private void Start()
    {
        tituloText.text = "Hola, introuduce tu edad";
        alertasText.text = "";

        enviarButton.onClick.AddListener(FuncionDelBoton);

    }

    public void FuncionDelBoton ()
    {
    int edad = int.Parse(respuestaInput.linkedTextComponent.text);
        edad = 12;
    }
}
