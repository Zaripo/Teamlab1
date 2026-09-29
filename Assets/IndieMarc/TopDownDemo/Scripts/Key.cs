using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Key script
/// Author: Indie Marc (Marc-Antoine Desbiens)
/// </summary>

namespace IndieMarc.TopDown
{

    public class Key : MonoBehaviour
    {

        public int key_index = 0;
        public int key_value = 1;

        [Header("Sounds")]
        public AudioClip takeSound;
        public AudioClip dropSound;
        public AudioClip unlockSound;
        [Range(0f, 1f)]
        public float soundVolume = 1f;

        private string unique_id;
        private CarryItem carry_item;
        private AudioSource audioSource;

        void Start()
        {
            carry_item = GetComponent<CarryItem>();
            carry_item.OnTake += OnTake;
            carry_item.OnDrop += OnDrop;

            // Получаем или создаём AudioSource
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
                audioSource.playOnAwake = false;
                audioSource.spatialBlend = 0f; // 2D звук; поставьте 1f для 3D
            }
        }

        private void OnTake(GameObject triggerer)
        {
            PlaySound(takeSound);
        }

        private void OnDrop(GameObject triggerer)
        {
            PlaySound(dropSound);
        }

        public bool TryOpenDoor(GameObject door)
        {
            if (door.GetComponent<Door>() && door.GetComponent<Door>().CanKeyUnlock(this) && !door.GetComponent<Door>().IsOpened())
            {
                door.GetComponent<Door>().UnlockWithKey(key_value);
                PlaySoundAt(unlockSound, transform.position);
                Destroy(gameObject);
                return true;
            }
            return false;
        }

        private void PlaySound(AudioClip clip)
        {
            if (clip == null || audioSource == null) return;
            audioSource.PlayOneShot(clip, soundVolume);
        }

        // Воспроизведение в точке — используется для звука двери,
        // т.к. объект ключа будет уничтожен сразу после этого
        private void PlaySoundAt(AudioClip clip, Vector3 position)
        {
            if (clip == null) return;
            AudioSource.PlayClipAtPoint(clip, position, soundVolume);
        }
    }

}