using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateMachine : MonoBehaviour
{
    // Estados do personagem
    public enum State { Idle, Running, Jumping }

    // Estado atual
    public State currentState;

    private void Start()
    {
        // Estado inicial
        ChangeState(State.Idle);
    }

    private void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangeState(State.Running);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            ChangeState(State.Idle);
        }

        // Executar a lógica do estado atual
        switch (currentState)
        {
            case State.Idle:
                // Lógica para Idle
                break;
            case State.Running:
                // Lógica para Running
                break;
            case State.Jumping:
                // Lógica para Jumping
                break;
        }
    }

    public void ChangeState(State newState)
    {
        currentState = newState;

        // Ações a serem executadas ao entrar no novo estado
        switch (newState)
        {
            case State.Idle:
                // Executar ações específicas para Idle
                break;
            case State.Running:
                // Executar ações específicas para Running
                break;
            case State.Jumping:
                // Executar ações específicas para Jumping
                break;
        }
    }
}

