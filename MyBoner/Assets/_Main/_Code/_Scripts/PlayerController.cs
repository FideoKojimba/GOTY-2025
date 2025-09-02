using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D r2b2d;
    [SerializeField]
    private float fuerza = 50f;
    [SerializeField]
    private Vector2 derecha = new Vector2(1, 1);
    [SerializeField]
    private Vector2 izquierda = new Vector2(-1, 1);
    [SerializeField]
    private Vector2 salto = new Vector2(0, 2);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        r2b2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            r2b2d.AddForce(izquierda * fuerza);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            r2b2d.AddForce(derecha * fuerza);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            r2b2d.AddForce(salto * fuerza);
        }
    }

}