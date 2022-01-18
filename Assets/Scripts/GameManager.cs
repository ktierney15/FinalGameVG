using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{


    [SerializeField] private GameObject thePlayer;
    private Vector3 playerStartPoint;

    [SerializeField] private  TMP_Text timerDisplay;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerStartPoint = thePlayer.transform.position;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        int seconds = (int)timer % 60;
        timerDisplay.text = seconds.ToString();
    }

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    private IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(0.5f);
        thePlayer.transform.position = playerStartPoint;
    }



}
