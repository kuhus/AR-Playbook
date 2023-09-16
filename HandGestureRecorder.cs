using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandGestureRecorder : MonoBehaviour
{
    public KeyCode startRecordKey = KeyCode.Space;
    public KeyCode stopRecordKey = KeyCode.S;

    private bool isRecording = false;
    private List<Vector3> leftHandPositions = new List<Vector3>();
    private List<Quaternion> leftHandRotations = new List<Quaternion>();
    private List<Vector3> rightHandPositions = new List<Vector3>();
    private List<Quaternion> rightHandRotations = new List<Quaternion>();

    void Update()
    {
        InputDevice leftHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        InputDevice rightHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        if (Input.GetKeyDown(startRecordKey))
        {
            isRecording = true;
            Debug.Log("Recording started.");
        }

        if (Input.GetKeyDown(stopRecordKey))
        {
            isRecording = false;
            Debug.Log("Recording stopped.");
            SaveRecordedData();
        }

        if (isRecording)
        {
            if (leftHandDevice.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 leftPosition) &&
                leftHandDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion leftRotation))
            {
                leftHandPositions.Add(leftPosition);
                leftHandRotations.Add(leftRotation);
            }

            if (rightHandDevice.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 rightPosition) &&
                rightHandDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion rightRotation))
            {
                rightHandPositions.Add(rightPosition);
                rightHandRotations.Add(rightRotation);
            }
        }
    }

    void SaveRecordedData()
    {
        // Implement your preferred method for saving the recorded data, e.g., to a file, a database, or a cloud service.
    }
}
