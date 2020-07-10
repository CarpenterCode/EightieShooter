using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] AudioMixer volumeMixer, effectMixer;
    [SerializeField] GameObject menuO, optionsO;

    GameObject soundTrack;
    private void Start()
    {
        //soundTrack = GameObject.FindGameObjectWithTag("SoundTrack");
        //soundTrack = GameObject.FindWithTag("SoundTrack");
    }

    public void BeginGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetVolume(float volume)
    {
        volumeMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }
    public void SetEffects(float volume)
    {
        effectMixer.SetFloat("effects", Mathf.Log10(volume) * 20);
    }

    public void SetSensitivity(float sens)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerLook>().mouseSensitivity = sens;
    }

    public void OpenOptions()
    {
        optionsO.SetActive(true);
        menuO.SetActive(false);
    }
    public void OpenMenu()
    {
        optionsO.SetActive(false);
        menuO.SetActive(true);
    }

    public void BackToMenu()
    {
        soundTrack = GameObject.Find("SoundTrackInGame");
        Destroy(soundTrack);
        SceneManager.LoadScene(0);
    }
}
