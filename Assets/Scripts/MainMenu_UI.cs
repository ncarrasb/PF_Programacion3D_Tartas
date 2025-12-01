using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_UI : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject panelMain;
    public GameObject panelInicio;
    public GameObject panelAjustes;

    [Header("Nombres Escenas")]
    public string levelSceneName = "Level_01";

    public void OnClick_Inicio()
    {
        panelMain.SetActive(false);
        panelInicio.SetActive(true);
    }

    public void OnClick_Ajustes()
    {
        panelMain.SetActive(false);
        panelAjustes.SetActive(true);
    }

    public void OnClick_Salir()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void OnClick_NuevaPartida()
    {
        SceneManager.LoadScene(levelSceneName);
    }

    public void OnClick_CargarPartida()
    {
        //Por el momento este boton será simplemente visual.
        Debug.Log("Cargar PArtida (Aún no está implementado)");
    }

    public void OnClick_VolverAlMenuDesdeInicio()
    {
        panelInicio.SetActive(false);
        panelMain.SetActive(true);
    }

    public void OnClick_VolverAlMenuDesdeAjustes()
    {
        panelAjustes.SetActive(false);
        panelMain.SetActive(true);
    }




    /*
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
