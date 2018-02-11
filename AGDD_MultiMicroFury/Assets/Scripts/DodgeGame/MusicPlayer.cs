using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource self;
    void StartFadeOut()
    {
        InvokeRepeating("FadeOut", 0.1f, 0.1f);
    }

    void FadeOut()
    {
        self.volume -= 0.02f;
        if (self.volume < 0)
        {
            self.Stop();
            CancelInvoke();
        }
    }
}
