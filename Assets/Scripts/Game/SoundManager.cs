using UnityEngine;

namespace Knpire.Game
{
    public class SoundManager : MonoBehaviour
    {
        private AudioSource audio;

        private void Awake()
        {
            this.audio = this.GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip clip)
        {
            this.audio.PlayOneShot(clip);
        }
    }
}
