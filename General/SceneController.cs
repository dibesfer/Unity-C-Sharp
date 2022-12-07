using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]string sceneName;
    public void Load()
    {
       //SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);

    }
}

