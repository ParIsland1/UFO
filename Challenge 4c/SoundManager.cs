using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource laserSound;

    void Awake()
{
    GameObject[] musicObjects = GameObject.FindGameObjectsWithTag("Music");
    if (musicObjects.Length > 1)
    {
        Destroy(this.gameObject);
    }
    else
    {
        // Background music to persist
        DontDestroyOnLoad(this.gameObject);
    }
}
    
    public void PlayButtonClickSound()
    {
         if (Input.GetKeyDown(KeyCode.Space));
        {
            laserSound.Play();
        }
        
    }
}
