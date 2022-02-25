using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader = default;
    [Tooltip("List of weapons. First one is primary, second is secondary.")]
    [SerializeField] private WeaponInterface[] weapons = default;

    #region InputSetup

    private void OnEnable()
    {
        _inputReader.attackPrimaryEvent += OnPrimaryAttack;
        _inputReader.attackPrimaryCancelledEvent += OnPrimaryAttackCancelled;
        _inputReader.attackSecondaryEvent += OnSecondaryAttack;
        _inputReader.attackSecondaryCancelledEvent += OnSecondaryAttackCancelled;
    }

    private void OnDisable()
    {
        _inputReader.attackPrimaryEvent -= OnPrimaryAttack;
        _inputReader.attackPrimaryCancelledEvent -= OnPrimaryAttackCancelled;
        _inputReader.attackSecondaryEvent -= OnSecondaryAttack;
        _inputReader.attackSecondaryCancelledEvent -= OnSecondaryAttackCancelled;
    }

    #endregion

    #region Weapon Firing

    // Gets input, calls script. Probably better way to implement using something more abstract.

    private void OnPrimaryAttack()
    {
        if (!WeaponCheck(0))
            return;
        weapons[0].OnFire();
    }

    private void OnPrimaryAttackCancelled()
    {
        if (!WeaponCheck(0))
            return;
        weapons[0].OnFireCancelled();
    }

    private void OnSecondaryAttack()
    {
        if (!WeaponCheck(1))
            return;
        weapons[1].OnFire();
    }

    private void OnSecondaryAttackCancelled()
    {
        if (!WeaponCheck(1))
            return;
        weapons[1].OnFireCancelled();
    }

    private bool WeaponCheck(int index)
    {
        if (weapons.Length > index)
            return true;
        Debug.Log("Weapon at index " + index + " not assigned.");
        return false;
    }

    #endregion
}
