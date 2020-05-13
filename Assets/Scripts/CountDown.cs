using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    float timer = 300f;
    public TextMeshProUGUI text;
    float countD;
    [SerializeField] private GameObject PauseMenuUI;
    [SerializeField] private bool ispaused;
    void Start()
    {
        countD = timer;
    }
    void Update()
    {

        countD -= Time.deltaTime;
        text.text = countD.ToString("f2");


        if (countD >= 0)
        {
            ActivationMenu();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ispaused = !ispaused;
        }
        if (ispaused)
        {
            ActivationMenu();
        }
        if (!ispaused)
        {
            DeactivationMenu();
        }
    }
    void ActivationMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        PauseMenuUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void DeactivationMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        PauseMenuUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
