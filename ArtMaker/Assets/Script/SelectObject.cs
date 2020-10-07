using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SelectObject : MonoBehaviour
{
    [SerializeField] GameObject bearMake;
    [SerializeField] GameObject tedyBear;
    public float scaleSpeedModifier;
    float scaleSpeed = 0.1f;
    GameObject selectableObj;
    public Vector3 headBodyScale = new Vector3(2f, 2f, 2f);
    public Vector3 legArmScale = new Vector3(2f, 1f, 1f);
    public Vector3 earScale = new Vector3(0.5f, 0.5f, 0.5f);
    bool leftEar = true;
    bool rightEar = true;
    bool head = true;
    bool body = true;
    bool leftArm = true;
    bool rightArm = true;
    bool leftLeg = true;
    bool rightLeg = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SelectObj();
        TouchDirection();
    }

    void SelectObj()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                selectableObj = null;

                if (hit.transform.CompareTag("Selectable"))
                {
                    selectableObj = hit.transform.gameObject;
                }
            }
        }
    }

    void TouchDirection()
    {
        if (Input.GetMouseButton(0) && selectableObj != null && (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0) )
        {
            if (selectableObj.name == "LeftEar" && leftEar)
            {
                Debug.Log("name: " + selectableObj.name);
                selectableObj.transform.localScale = new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
                scaleSpeed += scaleSpeedModifier;
                Debug.Log(scaleSpeed);

                if (selectableObj.transform.localScale == earScale)
                {
                    leftEar = false;
                    scaleSpeed = 0.1f;
                }
            }

            if (selectableObj.name == "RightEar" && rightEar)
            {
                Debug.Log("name: " + selectableObj.name);
                selectableObj.transform.localScale = new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
                scaleSpeed += scaleSpeedModifier;
                Debug.Log(scaleSpeed);

                if (selectableObj.transform.localScale == earScale)
                {
                    rightEar = false;
                    scaleSpeed = 0.1f;
                }
            }

            if (selectableObj.name == "Head" && head)
            {
                Debug.Log("name: " + selectableObj.name);
                selectableObj.transform.localScale = new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
                scaleSpeed += scaleSpeedModifier;
                Debug.Log(scaleSpeed);

                if (selectableObj.transform.localScale == headBodyScale)
                {
                    head = false;
                    scaleSpeed = 0.1f;
                }
            }

            if (selectableObj.name == "Body" && body)
            {
                Debug.Log("name: " + selectableObj.name);
                selectableObj.transform.localScale = new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
                scaleSpeed += scaleSpeedModifier;
                Debug.Log(scaleSpeed);

                if (selectableObj.transform.localScale == headBodyScale)
                {
                    body = false;
                    scaleSpeed = 0.1f;
                }
            }

            if (selectableObj.name == "RightArm" && rightArm)
            {
                Debug.Log("name: " + selectableObj.name);
                selectableObj.transform.localScale = new Vector3(scaleSpeed, scaleSpeed / 2, scaleSpeed / 2);
                scaleSpeed += scaleSpeedModifier;
                Debug.Log(scaleSpeed);

                if (selectableObj.transform.localScale == legArmScale)
                {
                    rightArm = false;
                    scaleSpeed = 0.1f;
                }
            }

            if (selectableObj.name == "LeftArm" && leftArm)
            {
                Debug.Log("name: " + selectableObj.name);
                selectableObj.transform.localScale = new Vector3(scaleSpeed, scaleSpeed / 2, scaleSpeed / 2);
                scaleSpeed += scaleSpeedModifier;
                Debug.Log(scaleSpeed);

                if (selectableObj.transform.localScale == legArmScale)
                {
                    leftArm = false;
                    scaleSpeed = 0.1f;
                }
            }

            if (selectableObj.name == "RightLeg" && rightLeg)
            {
                Debug.Log("name: " + selectableObj.name);
                selectableObj.transform.localScale = new Vector3(scaleSpeed, scaleSpeed / 2, scaleSpeed / 2);
                scaleSpeed += scaleSpeedModifier;
                Debug.Log(scaleSpeed);

                if (selectableObj.transform.localScale == legArmScale)
                {
                    rightLeg = false;
                    scaleSpeed = 0.1f;
                }
            }

            if (selectableObj.name == "LeftLeg" && leftLeg)
            {
                Debug.Log("name: " + selectableObj.name);
                selectableObj.transform.localScale = new Vector3(scaleSpeed, scaleSpeed / 2, scaleSpeed / 2);
                scaleSpeed += scaleSpeedModifier;
                Debug.Log(scaleSpeed);

                if (selectableObj.transform.localScale == legArmScale)
                {
                    leftLeg = false;
                    scaleSpeed = 0.1f;
                }
            }

            if (!body && !head && !leftArm && !rightArm && !leftLeg && !rightLeg && !leftEar && !rightEar)
            {
                bearMake.SetActive(false);
                tedyBear.SetActive(true);
            }
        }
    }
}
