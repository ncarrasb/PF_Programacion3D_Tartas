using UnityEngine;
using UnityEngine.UI;

public class NivelTimerBarraColor : MonoBehaviour
{
    [Header("Configuración")]
    public float tiempoInicial = 30f;

    [Header("Referencias UI")]
    public Slider barraTiempo;
    public Image fillBar;               // La parte de color de la barra
    public GameObject cartelDiaTerminado;

    private float tiempoRestante;
    private bool nivelIniciado = false;

    void Start()
    {
        tiempoRestante = tiempoInicial;

        // Configurar barra
        barraTiempo.maxValue = tiempoInicial;
        barraTiempo.value = tiempoInicial;

        cartelDiaTerminado.SetActive(false);
    }

    void Update()
    {
        if (nivelIniciado && tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;

            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                TerminarDia();
            }

            // Actualizar barra
            barraTiempo.value = tiempoRestante;

            // Cambiar color según tiempo restante
            ActualizarColorBarra();
        }
    }

    public void EmpezarNivel()
    {
        nivelIniciado = true;
    }

    void TerminarDia()
    {
        nivelIniciado = false;
        cartelDiaTerminado.SetActive(true);
    }

    void ActualizarColorBarra()
    {
        float porcentaje = tiempoRestante / tiempoInicial;

        if (porcentaje > 0.5f)
        {
            fillBar.color = Color.green;
        }
        else if (porcentaje > 0.25f)
        {
            fillBar.color = Color.yellow;
        }
        else
        {
            fillBar.color = Color.red;
        }
    }
}
