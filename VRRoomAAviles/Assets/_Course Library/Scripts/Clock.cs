using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] GameObject hourHand;
    [SerializeField] GameObject minuteHand;
    [SerializeField] GameObject secondHand;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateClock", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        float hourAngle = System.DateTime.Now.Hour / 12f * 360f;
        float minuteAngle = (System.DateTime.Now.Minute / 60f) *30f;
        float secondAngle = System.DateTime.Now.Second * (360 / 60);

        hourHand.transform.localRotation = Quaternion.Euler((hourAngle + 90), 0, 0);
        minuteHand.transform.localRotation = Quaternion.Euler((minuteAngle + 90), 0, 0);
        secondHand.transform.localRotation = Quaternion.Euler((secondAngle + 90), 0, 0);
    }
}
