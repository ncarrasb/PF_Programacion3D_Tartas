using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PuntuacionFinalUI : MonoBehaviour
{
    [Header("Textos")]
    public TMP_Text txtAciertos;
    public TMP_Text txtFallos;

    private void Start()
    {
        if (ScoreManager.Instance == null)
        {
            txtAciertos.text = "Aciertos: 0";
            txtFallos.text = "Fallos: 0";
            return;
        }

        txtAciertos.text = "Aciertos: " + ScoreManager.Instance.aciertos;
        txtFallos.text = "Fallos: " + ScoreManager.Instance.fallos;

    }

    public void Reintentar()
    {
        ScoreManager.Instance?.ResetScore();
        SceneManager.LoadScene("Level_01");
    }

    public void VolverMenu()
    {
        ScoreManager.Instance?.ResetScore();
        SceneManager.LoadScene("MainMenu");
    }
}
