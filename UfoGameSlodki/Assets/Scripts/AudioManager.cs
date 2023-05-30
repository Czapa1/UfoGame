using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] music;
    public Sound[] sfx;
    public AudioSource musicSource, sfxSource;
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(music, x => x.name == name);
        if (s==null)
        {
            Debug.Log("Sounud not found");
        }
        else
        {
            musicSource.clip = s.audioClip;
            musicSource.Play();
        }
    }
    public void PlaySfx(string name)
    {

    }
    // Start is called
}
