using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader = default;
    [SerializeField] private EntityMovementSO _dragonMoveData = default;

    private Rigidbody dragonRigidBody;
    private Transform dragonModel;

    private Vector2 rotateVector = Vector2.zero;

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

    private void Start()
    {
        dragonRigidBody = gameObject.GetComponent<Rigidbody>();
        dragonModel = transform.GetChild(0);
    }

    private void Update()
    {
        MoveForwardDragon();
        TurnDragon();
    }

    private void MoveForwardDragon()
    {
        dragonRigidBody.velocity = _dragonMoveData.Speed * _dragonMoveData.SpeedMultiplier * Time.deltaTime * transform.forward;
    }

    private void TurnDragon()
    {
        dragonRigidBody.AddRelativeTorque(_dragonMoveData.Torque * rotateVector.y, _dragonMoveData.Torque * rotateVector.x, 0);
    }

    private void OnMove(Vector2 movement)
    {

    }

    private void OnRotateCamera(Vector2 lookVector)
    {
        rotateVector = lookVector;
    }

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
}
