using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Osaburo : MonoBehaviour
{
    [SerializeField]
    private AudioSource voicePass = default;
    [SerializeField]
    private AudioSource voiceIntro = default;

    private int countPass = 0;
    private int countIntro = 0;

    private bool flagPass = false;
    private bool flagIntro = false;

    [SerializeField]
    private Text textPass = default;

    [SerializeField]
    private CameraRenderTexture cameraRenderTexture = default;

    public void SayPass()
    {
        voicePass.Play();
        if (flagPass == false)
        {
            countPass++;
        }
        if (countPass > 20)
        {
            voicePass.pitch += 0.02f;
            countPass = 0;
            if (voicePass.pitch > 1.25f)
            {
                voicePass.pitch = 0.4f;
                flagPass = true;
            }
        }
    }

    public void SayIntro()
    {
        voiceIntro.Play();
        if (flagIntro == false)
        {
            countIntro++;
        }
        if (countIntro > 20)
        {
            voiceIntro.pitch += 0.02f;
            countIntro = 0;
            if (voiceIntro.pitch > 1.25f)
            {
                voiceIntro.pitch = 0.4f;
                flagIntro = true;
            }
        }
    }
}
