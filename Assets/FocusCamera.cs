// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using System;
// using Vuforia;

// public class FocusCamera : MonoBehaviour
// {
//    void Start() {
//     OnSingleTapped();
//    }
//    void Update() {
//     if (Input.GetKey(KeyCode.Escape)) {
//         Application.Quit();
//     }
//     OnSingleTapped();
//    }
//    private void OnSingleTapped() {
//     TriggerAutoFocus();
//    }
//    public void TriggerAutoFocus() {
//     StartCoroutine(TriggerAutoFocusAndEnableContinuousFocusIfSet());
//    }
//    private IEnumerator TriggerAutoFocusAndEnableContinuousFocusIfSet(){
//     yield return new WaitForSeconds(0.5f);
//     VuforiaConfiguration.Instance.Vuforia.CameraDevice(CameraDevice.SetFocusMode.FOCUS_MODE_CONTONUOUSAUTO);
//    }
// }
