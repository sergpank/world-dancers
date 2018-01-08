using System;
using System.Linq;
using System.Threading;
using UnityEngine;
using GAF.Core;

public class CharacterInteraction : MonoBehaviour
{
    public GAFMovieClip clip = null;

    void Start()
    {
        clip.on_sequence_change += movieClip =>
        {
            Debug.Log("SC");
            var seqInfo = clip.asset.getSequences(clip.timelineID);
            var greetingId = clip.sequenceNameToIndex("greeting");
            var greeting = seqInfo.First(s => s.name.Equals("greeting"));
            if (movieClip.getCurrentSequenceIndex() == greetingId)
            {
                movieClip.gotoAndPlay(greeting.endFrame);
            }
        };
    }

    void OnMouseDown()
    {
        Debug.Log("Click " + this.gameObject.name);
        if (clip != null)
        {
            //clip.stop();
            //clip.play();

            //var seqInfo = clip.asset.getSequences(clip.timelineID);
            //var greeting = seqInfo.First(s => s.name.Equals("greeting"));
            
            clip.setSequence("loop_out", true);
            clip.setSequence("greeting", true);
            clip.setSequence("loop_in", true);
            clip.setSequence("loop", true);

        }
    }
}
