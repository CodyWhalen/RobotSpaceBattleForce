using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float timer = 0f;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    float coutup;
    [SerializeField] private GameObject PauseMenuUI;



    void Start()
    {
        coutup = timer;
    }
    void Update()
    {
        coutup += Time.deltaTime;
        text.text = coutup.ToString("f2");
        text2.text = coutup.ToString("f2");
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
            PauseMenuUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
