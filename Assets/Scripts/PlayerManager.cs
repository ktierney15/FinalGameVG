using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;
    public GameObject explosion;

    public AudioSource audioData;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "playerRestart")
        {

            GameObject ex = Instantiate(explosion, transform.position, Quaternion.identity);
            ex.transform.parent = collision.gameObject.transform;

            gameManager.RestartGame();
            audioData.Play(0);
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        transform.position = GameObject.FindWithTag("startPosition").transform.position;
        
    }



}
