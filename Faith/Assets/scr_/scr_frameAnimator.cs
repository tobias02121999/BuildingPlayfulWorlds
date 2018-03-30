using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_frameAnimator : MonoBehaviour {

    private float animationAlarm = 0f;
    private float animationSpeed;
    private int currentFrame = 0;
    private Mesh[] currentFrames;

    public MeshFilter mesh;
    public Mesh[] idleFrames;
    public float idleAnimationSpeed = 1f;
    public Mesh[] moveFrames; 
    public float moveAnimationSpeed = 1f;
    public int currentAnimation = 0;

	void Update () {
        switch (currentAnimation)
        {
            case 0:
                currentFrames = idleFrames;
                animationSpeed = idleAnimationSpeed;
                break;

            case 1:
                currentFrames = moveFrames;
                animationSpeed = moveAnimationSpeed;
                break;
        }

        if (animationAlarm >= 1)
        {
            if (currentFrame >= currentFrames.Length - 1)
            {
                currentFrame = 0;
            } else
            {
                currentFrame++;
            }
            animationAlarm = 0;
        }

        animationAlarm += animationSpeed;
        mesh.mesh = currentFrames[currentFrame];
	}
}
