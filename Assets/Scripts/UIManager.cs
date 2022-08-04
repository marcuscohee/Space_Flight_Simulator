using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _speedText;
    [SerializeField] private ShipController _shipController;
    [SerializeField] private GameObject _UIText;
    [SerializeField] private GameObject _resetUIText;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            _UIText.SetActive(false);
            _resetUIText.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            _UIText.SetActive(true);
            _resetUIText.SetActive(false);
        }
    }

    public void ShipSpeed(float shipSpeed)
    {
        _speedText.text = "Speed =" + shipSpeed;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void StartExperience()
    {
        SceneManager.LoadScene(1);
    }
}
