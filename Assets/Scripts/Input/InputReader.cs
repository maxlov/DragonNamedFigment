using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="InputReader", menuName ="Game/Input Reader")]
public class InputReader : DescriptionBaseSO, GameInput.IGameplayActions
{
    // Assign delegate{} to events to skip null checks.

    public event UnityAction<Vector2> moveEvent = delegate { };
    public event UnityAction<Vector2> rotateCameraEvent = delegate { };
    public event UnityAction attackPrimaryEvent = delegate { };
    public event UnityAction attackPrimaryCancelledEvent  = delegate { };
    public event UnityAction attackSecondaryEvent = delegate { };
    public event UnityAction attackSecondaryCancelledEvent = delegate { };
    public event UnityAction boostEvent = delegate { };
    public event UnityAction boostCancelledEvent = delegate { };
    public event UnityAction brakeEvent = delegate { };
    public event UnityAction brakeCancelledEvent = delegate { };
    public event UnityAction pauseEvent = delegate { };

    private GameInput _gameInput;

    private void OnEnable()
    {
        if (_gameInput == null)
        {
            _gameInput = new GameInput();

            _gameInput.Gameplay.SetCallbacks(this);
            _gameInput.Gameplay.Enable();
        }
    }

    private void OnDisable()
    {
        _gameInput.Gameplay.Disable();
    }

    #region Gameplay

    public void OnMove(InputAction.CallbackContext context)
    {
        if (!context.performed) { return; }

        moveEvent.Invoke(context.ReadValue<Vector2>());
    }

    public void OnRotateCamera(InputAction.CallbackContext context)
    {
        if (!context.performed) { return; }

        rotateCameraEvent.Invoke(context.ReadValue<Vector2>());
    }

    public void OnAttackPrimary(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                attackPrimaryEvent.Invoke();
                break;
            case InputActionPhase.Canceled:
                attackPrimaryCancelledEvent.Invoke();
                break;
        }
    }

    public void OnAttackSecondary(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                attackSecondaryEvent.Invoke();
                break;
            case InputActionPhase.Canceled:
                attackSecondaryCancelledEvent.Invoke();
                break;
        }
    }

    public void OnBoost(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                boostEvent.Invoke();
                break;
            case InputActionPhase.Canceled:
                boostCancelledEvent.Invoke();
                break;
        }
    }

    public void OnBrake(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                brakeEvent.Invoke();
                break;
            case InputActionPhase.Canceled:
                brakeCancelledEvent.Invoke();
                break;
        }
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (!context.performed) { return; }

        attackPrimaryEvent.Invoke();
    }

    #endregion
}
