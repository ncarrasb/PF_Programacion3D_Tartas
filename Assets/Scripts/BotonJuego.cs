using UnityEngine;
using UnityEngine.InputSystem;

public class BotonJuego : MonoBehaviour
{
    [Header("Configuración del Botón")]//sexooo
    public Ingredientes ingrediente;
    public PlayerManager playerManager;

    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerManager = FindFirstObjectByType<PlayerManager>();
        /*
        if (spriteRenderer && ingrediente.sprite)
            spriteRenderer.sprite = ingrediente.sprite;
        */
    }

    void OnMouseDown()
    {
        transform.localScale = Vector3.one * 0.9f;

        if (ingrediente.tipo == "Recipiente")
            playerManager.ElegirRecipiente(ingrediente);
        else if (ingrediente.tipo == "Helado")
            playerManager.ElegirHelado(ingrediente);
        else if (ingrediente.tipo == "Sabor")
            playerManager.ElegirSabor(ingrediente);
        else if (ingrediente.tipo == "Topping")
            playerManager.ElegirTopping(ingrediente);
    }

    void OnMouseUp()
    {
        transform.localScale = Vector3.one;
    }
}