using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public int aciertos;
    public int fallos;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ResetScore()
    {
        aciertos = 0;
        fallos = 0;
    }

    public void AddAcierto() => aciertos++;
    public void AddFallo() => fallos++;
}
