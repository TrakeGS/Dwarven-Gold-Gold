using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource sfxSource;
	public  AudioSource MusicSource;
	public  static SoundManager instance= null;

	public float lowPitch = 0.95f;
	public float hightPitch = 1.05f;

	// Use this for initialization

	void Awake () {
        if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
        
		DontDestroyOnLoad (this);
		
	}

	void PlaySingle(AudioClip clip)
	{
		sfxSource.clip = clip;
		sfxSource.Play();

	}

	public void RandomizeSFX( params AudioClip[] clips)
	{
		int randomIndex = Random.Range (0, clips.Length);
		float randomPitch = Random.Range (lowPitch, hightPitch);
		sfxSource.pitch = randomPitch;
		sfxSource.clip = clips [randomIndex];
		sfxSource.Play ();
	}
		
}
