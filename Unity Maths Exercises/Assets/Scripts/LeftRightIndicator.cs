using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightIndicator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Flash(true);
        if (Input.GetMouseButtonDown(1))
            Flash(false);
    }

    void Flash(bool isLeft)
    {
        foreach (Target target in Target.targets)
        {
            if (MathsUtils.IsOnLeft(transform, target.transform.position) == isLeft)
                target.Hit();
        }
    }
}
