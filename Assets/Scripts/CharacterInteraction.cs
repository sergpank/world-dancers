using UnityEngine;
using GAF.Core;

public class CharacterInteraction : MonoBehaviour
{
    public GAFMovieClip clip = null;

    void OnMouseUpAsButton()
    {
        if (clip != null)
        {
            clip.stop();
            clip.play();
        }
    }
}
