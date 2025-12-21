using UnityEngine;

public class UIAudioManager : MonoBehaviour
{
    public static UIAudioManager Instance;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip clickClip;

    void Awake()
    {
        // Singleton + persistencia
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Si no está asignado, intenta cogerlo del mismo objeto
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    public void PlayClick()
    {
        if (audioSource != null && clickClip != null)
            audioSource.PlayOneShot(clickClip);
    }
}