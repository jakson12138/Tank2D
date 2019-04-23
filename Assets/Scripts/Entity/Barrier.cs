﻿using UnityEngine;

public class Barrier : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// 在和砖碰到的时候播放声音
    /// </summary>
    public void PlayerAudio()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}