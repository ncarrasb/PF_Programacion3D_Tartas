using UnityEngine;

public class BotonSonidoUI : MonoBehaviour
{
    public void ReproducirSonido()
    {
        if (UIAudioManager.Instance != null)
        {
            UIAudioManager.Instance.PlayClick();
        }
    }
}