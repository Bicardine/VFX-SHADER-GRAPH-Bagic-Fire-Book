using UnityEngine;

namespace FireBook
{
    public class PlaySfxSound : MonoBehaviour
    {
        [SerializeField] private AudioSource _source;
        [SerializeField] private AudioClip _clip;

        public void Play()
        {
            _source.PlayOneShot(_clip);
        }

        private void Start() => Play();
    }
}