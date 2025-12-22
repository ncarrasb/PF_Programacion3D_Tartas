using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    [Header("Configuración")]
    public float tiempoInicial = 120f;
    public float esperaResultados = 2.5f;

    [Header("Referencias UI")]
    public Slider barraTiempo;
    public Image fillBar;               // La parte de color de la barra

    private float tiempoRestante;
    private bool nivelIniciado = false;

    void Start()
    {
        tiempoRestante = tiempoInicial;

        // Configurar barra
        barraTiempo.maxValue = tiempoInicial;
        barraTiempo.value = tiempoInicial;

        EmpezarNivel();
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

            barraTiempo.value = tiempoRestante;
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

        StartCoroutine(CargarResultadosTrasEspera());
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

    System.Collections.IEnumerator CargarResultadosTrasEspera()
    {
        yield return new WaitForSeconds(esperaResultados);

        Time.timeScale = 1f;

        SceneManager.LoadScene("PuntuaciónFinal");
    }
}
