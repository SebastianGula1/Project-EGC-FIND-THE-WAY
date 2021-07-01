using UnityEngine;
using UnityEngine.Audio;


public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer; 

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MusicVol", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen( bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
