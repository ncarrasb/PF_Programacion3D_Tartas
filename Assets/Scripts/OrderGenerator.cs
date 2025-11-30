using UnityEngine;

public class OrderGenerator : MonoBehaviour
{
    [Header("Masas / Conos")]
    public Ingredientes[] masas;

    [Header("Helados")]
    public Ingredientes[] helados;

    [Header("Toppings")]
    public Ingredientes[] toppings;

    [Header("Renderers que muestran la orden")]
    public SpriteRenderer masaRenderer;
    public SpriteRenderer heladoRenderer;
    public SpriteRenderer toppingRenderer;

    // IDs que definirá la orden generada
    [HideInInspector] public int masaID;
    [HideInInspector] public int heladoID;
    [HideInInspector] public int toppingID;

    void Start()
    {
        GenerarOrden();
    }

    public void GenerarOrden()
    {
        // MASA
        Ingredientes masa = masas[Random.Range(0, masas.Length)];
        masaRenderer.sprite = masa.sprite;
        masaID = masa.id;

        // HELADO
        Ingredientes helado = helados[Random.Range(0, helados.Length)];
        heladoRenderer.sprite = helado.sprite;
        heladoID = helado.id;

        // TOPPING
        Ingredientes topping = toppings[Random.Range(0, toppings.Length)];
        toppingRenderer.sprite = topping.sprite;
        toppingID = topping.id;

        Debug.Log("Orden generada -> Masa: " + masaID + " | Helado: " + heladoID + " | Topping: " + toppingID);
    }
}
