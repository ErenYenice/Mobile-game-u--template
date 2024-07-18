using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    public Button soundButton;
    public Button musicButton;
    public Sprite soundOnIcon;
    public Sprite soundOffIcon;
    public Sprite musicOnIcon;
    public Sprite musicOffIcon;

    private bool isSoundOn = true;
    private bool isMusicOn = true;

    void Start()
    {
        soundButton.onClick.AddListener(ToggleSound);
        musicButton.onClick.AddListener(ToggleMusic);
        UpdateSoundButton();
        UpdateMusicButton();
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

    void ToggleMusic()
    {
        isMusicOn = !isMusicOn;
        UpdateMusicButton();
        if (isMusicOn)
        {
        }
        else
        {
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

    void UpdateMusicButton()
    {
        if (isMusicOn)
        {
            musicButton.GetComponent<Image>().sprite = musicOnIcon;
        }
        else
        {
            musicButton.GetComponent<Image>().sprite = musicOffIcon;
        }
    }
}
