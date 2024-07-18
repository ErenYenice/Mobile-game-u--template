using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Button soundButton;
    public Sprite soundOnIcon;
    public Sprite soundOffIcon;

    private bool isSoundOn = true;

    void Start()
    {
        soundButton.onClick.AddListener(ToggleSound);
        UpdateSoundButton();
        
    }

    void ToggleSound()
    {
        isSoundOn = !isSoundOn;
        UpdateSoundButton();
        if (isSoundOn)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }

   
    void UpdateSoundButton()
    {
        if (isSoundOn)
        {
            soundButton.GetComponent<Image>().sprite = soundOnIcon;
        }
        else
        {
            soundButton.GetComponent<Image>().sprite = soundOffIcon;
        }
    }

   

}
