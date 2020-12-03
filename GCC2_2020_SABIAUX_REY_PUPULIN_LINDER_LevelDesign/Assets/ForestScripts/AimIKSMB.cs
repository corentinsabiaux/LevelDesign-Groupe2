﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimIKSMB : StateMachineBehaviour
{
    public Vector3 Direction;
    public float Distance;
    IKController _controller;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _controller = animator.gameObject.GetComponent<IKController>();
        if (_controller == null) return;

        _controller.LookTarget = Camera.main.transform.position + Camera.main.transform.TransformDirection(Direction.normalized) * Distance;
        _controller.Weight = 1;
        _controller.BodyWeight = 1;
        _controller.HeadWeight = 1;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_controller == null) return;
        _controller.LookTarget = Camera.main.transform.position + Camera.main.transform.TransformDirection(Direction.normalized) * Distance;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_controller == null) return;

        _controller.Weight = 0;
        _controller.BodyWeight = 0;
        _controller.HeadWeight = 0;
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
