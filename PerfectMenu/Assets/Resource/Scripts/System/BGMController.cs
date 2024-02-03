using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    [SerializeField] AudioSource bgmAudioSource;

    [SerializeField] List<BGMSoundData> bgmSoundDatas;

    public float bgmMasterVolume = 1;

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

        PlayBGM(BGMSoundData.BGM.InGame);
    }

    public void PlayBGM(BGMSoundData.BGM bgm)
    {
        BGMSoundData data = bgmSoundDatas.Find(data => data.bgm == bgm);
        bgmAudioSource.clip = data.audioClip;
        bgmAudioSource.volume = data.volume * bgmMasterVolume;
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
        Hoge, // ‚±‚ê‚ªƒ‰ƒxƒ‹‚É‚È‚é
    }

    public BGM bgm;
    public AudioClip audioClip;
    [Range(0, 1)]
    public float volume = 1;
}