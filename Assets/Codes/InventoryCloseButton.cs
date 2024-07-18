using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryCloseButton : MonoBehaviour
{
    public void OnCloseButtonClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}
