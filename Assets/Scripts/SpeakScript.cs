using UnityEngine;
using GAF.Core;
using GAFInternal.Core;

public class SpeakScript : MonoBehaviour {

    public GAFMovieClip clip = null;
    public uint triggerAtFrame = 7;

    private void Awake()
    {
        if (clip != null)
        {
            clip.addTrigger(OnCallback, triggerAtFrame);
        }
    }

    private void OnCallback(GAFBaseClip obj)
    {
        var audioSource = GetComponent<AudioSource>();
        if(audioSource != null)
        {
            audioSource.Play();
        }
    }
}
