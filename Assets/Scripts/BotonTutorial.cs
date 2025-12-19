using UnityEngine;

public class BotonTutorial : MonoBehaviour
{
    [Header("Sonido (opcional)")]
    public AudioClip sonidoClick;
    private AudioSource audioSource;

    [Header("Objetos a desactivar")]
    public GameObject[] desactivar;

    [Header("Objetos a activar")]
    public GameObject[] activar;

    private Vector3 escalaOriginal;

    void Start()
    {
        escalaOriginal = transform.localScale;
        audioSource = FindFirstObjectByType<AudioSource>();
    }

    void OnMouseDown()
    {
        transform.localScale = escalaOriginal * 0.9f;

        if (sonidoClick != null && audioSource != null)
            audioSource.PlayOneShot(sonidoClick);

        CambiarObjetos();
    }

    void OnMouseUp()
    {
        transform.localScale = escalaOriginal;
    }

    void CambiarObjetos()
    {
        foreach (GameObject go in desactivar)
            if (go != null) go.SetActive(false);

        foreach (GameObject go in activar)
            if (go != null) go.SetActive(true);
    }
}
