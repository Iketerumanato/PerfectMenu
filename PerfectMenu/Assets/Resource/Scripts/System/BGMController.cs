using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class BGMController : MonoBehaviour
{
    [SerializeField] AudioSource bgmAudioSource;

    [SerializeField] List<BGMSoundData> bgmSoundDatas;

    [SerializeField] Slider bgmVolumeSlider;

    public static BGMController _bgmcontroller { get; private set; }

    private void Awake()
    {
        if (_bgmcontroller == null)
        {
            _bgmcontroller = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayBGM(BGMSoundData.BGM bgm)
    {
        BGMSoundData data = bgmSoundDatas.Find(data => data.bgm == bgm);
        bgmAudioSource.clip = data.audioClip;
        bgmAudioSource.volume = data.volume;
        bgmVolumeSlider.value = bgmAudioSource.volume;
        bgmAudioSource.Play();
    }
}

[System.Serializable]
public class BGMSoundData
{
    public enum BGM
    {
        Title,
        InGame,
    }

    public BGM bgm;
    public AudioClip audioClip;
    [Range(0f, 1f)]
    public float volume = 1f;
}