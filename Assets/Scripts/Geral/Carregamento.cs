using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carregamento : MonoBehaviour
{
    public static Carregamento Instance;
    

    [SerializeField] private GameObjetc carregarCanvas
    [SerializeField] private Image progressoBar

    private void Awake() {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObjetc);
        }
        else
        {
            Destroy(gameObjetc);
        }
    }

    public async void LoadScene(String sceneName)
    {
        var scene = SceneManager.LoadSceneAsync(sceneName);
        scene.allowSceneActivation = false;

        carregarCanvas.setActive(true);

        do
        {
            
        } while (useGUILayout);
    }
}
