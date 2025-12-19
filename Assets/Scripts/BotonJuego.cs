using UnityEngine;
using UnityEngine.InputSystem;

public class BotonJuego : MonoBehaviour
{
    [Header("Configuración del Botón")]
    public Ingredientes ingrediente;
    public PlayerManager playerManager;


    public AudioClip sonidoClick;
    private AudioSource audioSource;

    private SpriteRenderer spriteRenderer;
    private Vector3 escalaOriginal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerManager = FindFirstObjectByType<PlayerManager>();
        audioSource = playerManager.GetComponent<AudioSource>();
        escalaOriginal = transform.localScale;

        /*
        if (spriteRenderer && ingrediente.sprite)
            spriteRenderer.sprite = ingrediente.sprite;
        */
    }

    void OnMouseDown()
    {
        transform.localScale = escalaOriginal * 0.9f;


        if (sonidoClick != null && audioSource != null)
            audioSource.PlayOneShot(sonidoClick);

     
        if (CompareTag("NextHelado"))
        {
            Debug.Log("Comprobando pedido...");
            playerManager.ComprobarOrden();
        }
        else
        {
            if (ingrediente.tipo == "Recipiente")
                playerManager.ElegirRecipiente(ingrediente);
            else if (ingrediente.tipo == "Helado")
                playerManager.ElegirHelado(ingrediente);
            else if (ingrediente.tipo == "Sabor")
                playerManager.ElegirSabor(ingrediente);
            else if (ingrediente.tipo == "Topping")
                playerManager.ElegirTopping(ingrediente);
        }
    }

    void OnMouseUp()
    {
        transform.localScale = escalaOriginal;
    }
}