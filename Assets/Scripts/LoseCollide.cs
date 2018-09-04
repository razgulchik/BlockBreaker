using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollide : MonoBehaviour {

    [SerializeField] AudioClip breakSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        SceneManager.LoadScene("Game Over");
    }

}
