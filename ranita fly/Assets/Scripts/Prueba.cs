using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Prueba : MonoBehaviour
{
    public TextMeshProUGUI puntosText;
    public SpriteRenderer[] vidas;
    public animationManager animManager;

    private int puntos;
    private int vidasRestantes;

    public int puntosParaAvanzar = 10; 
    public string siguienteEscena = "02-SegundoNivel"; 

    void Start()
    {
        puntos = 0;
        vidasRestantes = vidas.Length;
        ActualizarUI();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                animManager.Lengua(); 

                Animator objAnim = hit.collider.GetComponent<Animator>();

                if (hit.collider.CompareTag("mosquito"))
                {
                    puntos++;
                    ActualizarUI();

                    animManager.ComerMosquito();
                    animManager.Impacto(objAnim);

                    Destroy(hit.collider.gameObject, 0.3f);

                    RevisarCambioDeEscena(); 
                }
                else if (hit.collider.CompareTag("tapa") || hit.collider.CompareTag("corcho"))
                {
                    QuitarVida();

               
                    animManager.ComerBasura();
                    animManager.Impacto(objAnim);

                    Destroy(hit.collider.gameObject, 0.3f);
                }
            }
        }
    }

    void QuitarVida()
    {
        if (vidasRestantes > 0)
        {
            vidasRestantes--;
            vidas[vidasRestantes].enabled = false;
        }

        if (vidasRestantes <= 0)
        {
            SceneManager.LoadScene("04-Derrota");
        }
    }

    void ActualizarUI()
    {
        puntosText.text = "Puntos: " + puntos;
    }

    void RevisarCambioDeEscena()
    {
        if (puntos >= puntosParaAvanzar)
        {
            SceneManager.LoadScene(siguienteEscena);
        }
    }
}
