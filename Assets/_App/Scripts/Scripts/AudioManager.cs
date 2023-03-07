using SoudToy;
using UnityEngine;

namespace Assets.BanSung.Scripts
{/// <summary>
 /// 
 /// </summary>
    public class AudioManager : Singleton<AudioManager>
    {
        public AudioSource _AudioSource;

        public void Play(AudioClip clip)
        {
            _AudioSource.PlayOneShot(clip);
        }
    }
}