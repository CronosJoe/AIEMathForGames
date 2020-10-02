using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBreath : MonoBehaviour
{
    ParticleSystem particles;
    public bool isCylinder = false;
    
    // Start is called before the first frame update
    void Start()
    {
        particles = GetComponent<ParticleSystem>();
        if (particles && particles.shape.angle == 0)
            isCylinder = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // read the particle's angle in degrees
            float angle = particles.shape.angle;

            // 0.5 = scale of the cylinder
            float radius = particles.shape.radius * 0.5f;

            // read the particles distance travelled, ie the length of the cone times scale of cylinder
            float range = particles.main.startLifetime.constant * particles.main.startSpeed.constant * 0.5f;

            // for each target in the scene, check if they're inside our cone
            // if they are, make their particle system go off
            foreach (Target target in Target.targets)
            {
                if (isCylinder == false)
                {
                    if (MathsUtils.IsInCone(target.transform.position, transform.position, transform.up, angle, range))
                        target.Hit();
                }
                else
                {
                    if (MathsUtils.IsInCylinder(target.transform.position, transform.position, transform.up, radius, range))
                        target.Hit();
                }
            }
        }
    }
}
