using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Referencia al OrderGenerator
    public OrderGenerator orderGenerator;

    // Renderers donde se muestra lo que el jugador arma
    [Header ("Renderers del pedido del jugador")]
    public SpriteRenderer recipienteRendererJugador;
    public SpriteRenderer heladoRendererJugador;
    public SpriteRenderer saboresRendererJugador;
    public SpriteRenderer toppingRendererJugador;

    // IDs elegidos por el jugador
    private int jugadorRecipienteID = -1;
    private int jugadorHeladoID = -1;
    private int jugadorSaboresID = -1;
    private int jugadorToppingID = -1;

    // ===========================
    //  MÉTODOS PARA ELEGIR OPCIONES
    // ===========================

    public void ElegirRecipiente(Ingredientes recipiente)
    {
        recipienteRendererJugador.sprite = recipiente.sprite;
        jugadorRecipienteID = recipiente.id;
        Debug.Log("Jugador eligió recipiente ID: " + jugadorRecipienteID);
    }

    public void ElegirHelado(Ingredientes helado)
    {
        heladoRendererJugador.sprite = helado.sprite;
        jugadorHeladoID = helado.id;
        Debug.Log("Jugador eligió helado ID: " + jugadorHeladoID);
    }

    public void ElegirSabor(Ingredientes sabor)
    {
        saboresRendererJugador.sprite= sabor.sprite;
        jugadorSaboresID = sabor.id;
    }

    public void ElegirTopping(Ingredientes topping)
    {
        toppingRendererJugador.sprite = topping.sprite;
        jugadorToppingID = topping.id;
        Debug.Log("Jugador eligió topping ID: " + jugadorToppingID);
    }

    // ===========================
    //  COMPROBAR ORDEN
    // ===========================

    public void ComprobarOrden()
    {
        if (jugadorRecipienteID == -1 || jugadorHeladoID == -1 || jugadorSaboresID == -1 || jugadorToppingID == -1)
        {
            Debug.Log("El jugador no ha terminado su pedido.");
            return;
        }

        bool recipienteOK = jugadorRecipienteID == orderGenerator.recipienteID;
        bool heladoOK = jugadorHeladoID == orderGenerator.heladoID;
        bool saboresOK = jugadorSaboresID == orderGenerator.saboresID;
        bool toppingOK = jugadorToppingID == orderGenerator.toppingID;

        if (recipienteOK && heladoOK && saboresOK && toppingOK)
        {
            Debug.Log("✔️ ORDEN CORRECTA");
        }
        else
        {
            Debug.Log("❌ ORDEN INCORRECTA");
            Debug.Log("Jugador: " + jugadorRecipienteID + ", " + jugadorHeladoID + ", " + jugadorSaboresID + ", " + jugadorToppingID);
            Debug.Log("Orden:   " + orderGenerator.recipienteID + ", " + orderGenerator.heladoID + ", " + orderGenerator.saboresID + ", " + orderGenerator.toppingID);
        }
    }
}
