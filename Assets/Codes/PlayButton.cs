using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
