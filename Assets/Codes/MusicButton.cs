using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    public Button musicButton;
    public Sprite musicOnIcon;
    public Sprite musicOffIcon;
    public AudioSource musicSource;

    private bool isMusicOn = true;

    void Start()
    {
        if (musicSource != null && isMusicOn)
        {
            musicSource.Play();
        }

        musicButton.onClick.AddListener(ToggleMusic);
        UpdateMusicButton();
    }

    void ToggleMusic()
    {
        isMusicOn = !isMusicOn;
        UpdateMusicButton();

        if (isMusicOn)
        {
            musicSource.Play();
        }
        else
        {
            musicSource.Pause();
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
