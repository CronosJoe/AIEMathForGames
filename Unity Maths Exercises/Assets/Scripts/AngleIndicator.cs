using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleIndicator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            int index = 0;

            // display the order of each object, from 1 to N, clockwise
            foreach (Target target in Target.targets)
            {
                index++;
                target.SetText(index.ToString());
            }
        }
        else
        {
            // display the actual angles above each target
            foreach (Target target in Target.targets)
            {
                target.SetText(MathsUtils.AngleTo(transform, target.transform.position).ToString("0.0"));
            }
        }

        // sort the targets in order ofn their angle to the player
        Target.targets.Sort(delegate (Target a, Target b) {
            return MathsUtils.AngleTo(transform, a.transform.position).CompareTo(MathsUtils.AngleTo(transform, b.transform.position));
        });
    }
}
