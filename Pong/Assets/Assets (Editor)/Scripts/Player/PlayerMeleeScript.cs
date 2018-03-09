﻿using UnityEngine;

public class PlayerMeleeScript : MonoBehaviour {


    public GameObject Pipe;
    private PipeAnimationHandler animator;
    public PlayerMovementController movement;
	public bool inAnimation =false;

    // Use this for initialization
    void Start () {
        animator = Pipe.GetComponent<PipeAnimationHandler>();
	}
	
	// Update is called once per frame
	void Update () {
        if (PauseManager.Paused) return;
        if (movement.AmBusy()) return; //Don't shoot people while in dialogue with them

	    if (Input.GetMouseButtonDown(0))
	    {
	        PlayerWeaponEquip.timer = 1.1f;
	        animator.Attack();
			var tmp = GetComponentInParent<SoundController> ();
			if(!tmp.source.isPlaying){
				tmp.PlaySwingW ();
			}
	    }

    }

	public void swing(){
		inAnimation = true;
	}
	public void notSwing(){
		inAnimation = false;
	}
}
