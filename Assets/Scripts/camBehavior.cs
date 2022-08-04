using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camBehavior : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _cockpitView;
    [SerializeField] private CinemachineVirtualCamera _3rdPersonView;
    //[SerializeField] private Vector3 _mousePosition;
    //[SerializeField] private Vector3 _newMousePosition;
    //[SerializeField] private bool _hasCoroutineStarted = false;
    //[SerializeField] private GameObject _cinematicScene;

    private void Start()
    {
        _cockpitView.Priority = 15;
        _3rdPersonView.Priority = 10;
        //_mousePosition = Input.mousePosition;
        //_newMousePosition = Input.mousePosition;
    }

    void Update()
    {
        SwitchingCameras();
        //CheckingInput();
    }

    void SwitchingCameras()
    {
        if (Input.GetKeyDown(KeyCode.R) && _cockpitView.Priority > 10)
        {
            _3rdPersonView.Priority = 15;
            _cockpitView.Priority = 10;
        }
        else if (Input.GetKeyDown(KeyCode.R) && _3rdPersonView.Priority > 10)
        {
            _cockpitView.Priority = 15;
            _3rdPersonView.Priority = 10;
        }
    }

    // Cut out because it's no longer needed

    /*void CheckingInput()
    {
        _mousePosition = Input.mousePosition;
       if (_mousePosition != _newMousePosition || Input.anyKey)
       {
            _cinematicScene.SetActive(false);
            _newMousePosition = Input.mousePosition;
            _hasCoroutineStarted = false;
            StopAllCoroutines();
       }
       else
       {
            if (_hasCoroutineStarted == true)
            {
                return;
            }
            StartCoroutine(StartCinematicSequence());
       }
    }

    IEnumerator StartCinematicSequence()
    {
        _hasCoroutineStarted = true;
        yield return new WaitForSeconds(10.0f);
        _cinematicScene.SetActive(true);
    }*/
}
