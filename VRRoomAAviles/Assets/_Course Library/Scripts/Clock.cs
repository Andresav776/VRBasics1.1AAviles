<<<<<<< Updated upstream
=======
<<<<<<< HEAD
using System;
=======
>>>>>>> e484deb5dee773681e12a9a359a499cb0c7d82e5
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
    void UpdateClock()
    {
        float hourAngle = System.DateTime.Now.Hour * (360 / 12);
        float minuteAngle = System.DateTime.Now.Minute * (360 / 60);
        float secondAngle = DateTime.Now.Second * (360 / 60);

        hourHand.transform.localRotation = Quaternion.Euler(hourAngle, 0, 0);
        minuteHand.transform.localRotation = Quaternion.Euler(minuteAngle, 0, 0);
        secondHand.transform.localRotation = Quaternion.Euler(secondAngle, 0, 0);
=======
>>>>>>> Stashed changes
    void Update()
    {
        float hourAngle = System.DateTime.Now.Hour / 12f * 360f;
        float minuteAngle = (System.DateTime.Now.Minute / 60f) *30f;
        float secondAngle = System.DateTime.Now.Second * (360 / 60);

        hourHand.transform.localRotation = Quaternion.Euler((hourAngle + 90), 0, 0);
        minuteHand.transform.localRotation = Quaternion.Euler((minuteAngle + 90), 0, 0);
        secondHand.transform.localRotation = Quaternion.Euler((secondAngle + 90), 0, 0);
<<<<<<< Updated upstream
=======
>>>>>>> e484deb5dee773681e12a9a359a499cb0c7d82e5
>>>>>>> Stashed changes
    }
}
