using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IState {

    void SetState(StateMachineBehaviour owner);
    void OnStart();
    void OnUpdate();
    void OnExit();



}
