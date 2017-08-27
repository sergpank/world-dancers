using UnityEngine;

public class DoNotDestroy : MonoBehaviour {

	void Awake()
    {
        DontDestroyOnLoad(gameObject);

        var audioSource = GetComponent<AudioSource>();

        if(audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }        
    }
}
