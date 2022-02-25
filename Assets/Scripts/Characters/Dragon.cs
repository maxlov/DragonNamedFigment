using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader = default;
    [SerializeField] private EntityMovementSO _dragonMoveData = default;

    private Rigidbody dragonRigidBody;
    private Transform dragonModel;

    [SerializeField] private Transform aimTarget;

    private Vector2 rotateVector = Vector2.zero;
    private Vector2 moveVector = Vector2.zero;

    #region Input Setup

    private void OnEnable()
    {
        _inputReader.moveEvent += OnMove;
        _inputReader.rotateCameraEvent += OnRotateCamera;
        _inputReader.boostEvent += OnBoost;
        _inputReader.boostCancelledEvent += OnBoostCancelled;
        _inputReader.brakeEvent += OnBrake;
        _inputReader.brakeCancelledEvent += OnBrakeCancelled;
    }

    private void OnDisable()
    {
        _inputReader.moveEvent -= OnMove;
        _inputReader.rotateCameraEvent -= OnRotateCamera;
        _inputReader.boostEvent -= OnBoost;
        _inputReader.boostCancelledEvent -= OnBoostCancelled;
        _inputReader.brakeEvent -= OnBrake;
        _inputReader.brakeCancelledEvent -= OnBrakeCancelled;
    }

    #endregion

    private void Start()
    {
        dragonRigidBody = gameObject.GetComponent<Rigidbody>();
        dragonModel = transform.GetChild(0);
    }

    private void Update()
    {
        MoveForwardDragon();
        MoveHorizontalDragon();
        TurnDragon();
    }

    private void MoveForwardDragon()
    {
        dragonRigidBody.velocity = _dragonMoveData.Speed * _dragonMoveData.SpeedMultiplier * Time.deltaTime * transform.forward;
    }

    private void MoveHorizontalDragon()
    {
        transform.position += 2 * Time.deltaTime * new Vector3(moveVector.x, moveVector.y);
    }

    private void TurnDragon()
    {
        dragonRigidBody.AddRelativeTorque(_dragonMoveData.YTorque * rotateVector.y * Time.deltaTime, _dragonMoveData.XTorque * rotateVector.x * Time.deltaTime, 0);
    }

    private void OnMove(Vector2 movement)
    {
        moveVector = movement;
    }

    private void OnRotateCamera(Vector2 lookVector)
    {
        rotateVector = lookVector;
    }

    #region Speed Modifiers

    private void OnBoost()
    {
        _dragonMoveData.SetSpeedMultiplier(_dragonMoveData.BoostMultiplier);
    }

    private void OnBoostCancelled()
    {
        _dragonMoveData.SetSpeedMultiplier(_dragonMoveData.BaseSpeedMultiplier);
    }

    private void OnBrake()
    {
        _dragonMoveData.SetSpeedMultiplier(_dragonMoveData.BrakeMultiplier);
    }

    private void OnBrakeCancelled()
    {
        _dragonMoveData.SetSpeedMultiplier(_dragonMoveData.BaseSpeedMultiplier);
    }

    #endregion
}
