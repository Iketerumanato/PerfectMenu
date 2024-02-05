using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEController : MonoBehaviour
{
    [SerializeField] AudioSource seAudioSource;
    [SerializeField] List<SESoundData> seSoundDatas;
    [SerializeField] Slider seVolumeSlider;

    public static SEController _secontroller { get; private set; }

    private void Awake()
    {
        if (_secontroller == null)
        {
            _secontroller = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySE(SESoundData.SE se)
    {
        SESoundData data = seSoundDatas.Find(data => data.se == se);
        seAudioSource.volume = data.volume;
        foreach (SESoundData seData in seSoundDatas) seVolumeSlider.value = seAudioSource.volume;
        seAudioSource.PlayOneShot(data.audioClip);
    }



    [System.Serializable]
    public class SESoundData
    {
        public enum SE
        {
            Click
        }

        public SE se;
        public AudioClip audioClip;
        [Range(0, 1)]
        public float volume = 1;
    }
}
