using UnityEngine;

public class OrderGenerator : MonoBehaviour
{
    [Header("Recipientes")]
    public Ingredientes[] recipientes;

    [Header("Helados")]
    public Ingredientes[] helados;

    [Header("Toppings")]
    public Ingredientes[] toppings;

    [Header("Renderers que muestran el pedido")]
    public SpriteRenderer recipienteRenderer;
    public SpriteRenderer heladoRenderer;
    public SpriteRenderer toppingRenderer;

    // IDs que definirá la orden generada
    [HideInInspector] public int recipienteID;
    [HideInInspector] public int heladoID;
    [HideInInspector] public int toppingID;

    void Start()
    {
        GenerarOrden();
    }

    public void GenerarOrden()
    {
        // RECIPIENTE
        Ingredientes recipiente = recipientes[Random.Range(0, recipientes.Length)];
        recipienteRenderer.sprite = recipiente.sprite;
        recipienteID = recipiente.id;

        // HELADO
        Ingredientes helado = helados[Random.Range(0, helados.Length)];
        heladoRenderer.sprite = helado.sprite;
        heladoID = helado.id;

        // TOPPING
        Ingredientes topping = toppings[Random.Range(0, toppings.Length)];
        toppingRenderer.sprite = topping.sprite;
        toppingID = topping.id;

        Debug.Log("Orden generada -> Recipiente: " + recipienteID + " | Helado: " + heladoID + " | Topping: " + toppingID);
    }
}
