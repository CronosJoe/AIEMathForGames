using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathsUtils : MonoBehaviour
{
    // return true if the point is on the right side of the given Transform
    public static bool IsOnLeft(Transform user, Vector3 point)
    {
        // use the dot product

        return true;
    }

    // returns true if the point position is inside a cone starting at origin, with a forward vector, angle in degrees and a range in units
    public static bool IsInCone(Vector3 position, Vector3 origin, Vector3 forward, float angle, float range)
    {
        // you'll want to transform position into the cooridinate space of the cone, and decompose it into a forward component
        // and sideways component. 

        // The forward component should be between 0 and range, and the sideways component should be less than a vale representing the radius
        // of the cone at that distance.

        // a 45 degrees cone means that sideways has to be less than or equals to 1 * range. A tigher cone has a smaller multipler.
        // what trig do we use to get this multipler?

        return true;
    }

    public static bool IsInCylinder(Vector3 position, Vector3 origin, Vector3 forward, float radius, float range)
    {
        // you'll want to transform position into the cooridinate space of the cylinder, and decompose it into a forward component
        // and sideways component, same as the cone. 

        // The forward component should be between 0 and range, and the sideways component should be less than the radius

        return true;
    }

    // return the angle in degrees from the forward axis of the user transform to the vector from user origin to pos
    public static float AngleTo(Transform user, Vector3 pos)
    {
        float angle = 0;
        // look up Mathf.Atan2
        // it takes cartesian coordinates (x and y) and turns them into an angle via than inverse tan (Atan), 
        // but takes care of all the fiddly stuff to do with quadrants for you.
        // atan2 is also available in C++, so its always good to know!

        // make sure your angle ranges 0 to 360 - Atan2 will return a range of -Pi to Pi in radians

        return angle;
    }

    public static void FollowImmediate(Transform user, Vector3 target)
    {
        // this can be done in one line of code.
        // consider all the ways of setting rotation in Unity's Transform class

    }

    public static void FollowDelayed(Transform user, Vector3 target, float speed)
    {
        // find the forward vector we want


        // get the quaternion corresponding to that forward vector

        // move towards it at a steady speed. Vector3.MoveTowards is great for positions. 
        // See if Quaternions have something similar
        
    }

    public static void FollowImmediateHorizontal(Transform user, Vector3 target)
    {
        // point straight at the target as per FollowImmediate
        
        // zero the rotation around x and z so we're just left with rotation around y
        // is this a job for rotation, eulerANgles or the various axes Vector3s?
        
    }

    public static void FollowDelayedHorizontal(Transform user, Vector3 target, float speed)
    {
        
        // get the desired rotation around y using a trig helper function we've already used
        // to turn x and z into an angle
        
        // get the current euler angles

        // use a maths helper function that wraps us nicely around the 360 degrees boundary
        // its another 'MoveTowards' type function in Mathf namespace
        
        // set the current euler angles appropriately 
    }


}
