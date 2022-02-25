using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "Weapons/WeaponSO")]
public class WeaponSO : ScriptableObject
{
    public enum WeaponFireMode { AUTO };
    public WeaponFireMode weaponFireMode;

    #region WEAPON TRAITS
        [Header("Basic Weapon Traits")]
        public GameObject projectilePrefab;
        public float projectileVelocity = 10f;
        public float weaponScreenShake = 1.0f;
        public float numProjectilesToFire = 1;
        public float damage = 1f;
        public float lifeTime = 10f;
    #endregion

    [Tooltip("Only has effect is weapon is set to AUTO fire mode")]
    public float fireRate = 0.2f;
}
