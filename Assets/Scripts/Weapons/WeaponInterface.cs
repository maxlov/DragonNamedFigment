using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponInterface : MonoBehaviour
{
    [SerializeField] private WeaponSO weaponData;

    [Tooltip("Where the projectile spawns. If left null, spawn point is set to game object")]
    [SerializeField] private Transform projectileSpawnPoint;

    public UnityEvent OnShootEvent = new UnityEvent();

    private bool isShooting = false;
    //private float timeSinceLastFire = 0f;

    private void Start()
    {
        if (projectileSpawnPoint == null)
            projectileSpawnPoint = transform;
    }

    private void Update()
    {
        if (!isShooting)
            return;
        //if (weaponData.weaponFireMode == WeaponSO.WeaponFireMode.AUTO && timeSinceLastFire < weaponData.fireRate)
        //    return;

        ShootWeapon();
        OnShoot();

        if (weaponData.weaponFireMode != WeaponSO.WeaponFireMode.AUTO)
            isShooting = false;
    }

    private void ShootWeapon()
    {
        Debug.Log("pew");
        GameObject bullet = Instantiate(weaponData.projectilePrefab, projectileSpawnPoint.position, transform.rotation);
        ProjectileLogic bulletLogic = bullet.GetComponent<ProjectileLogic>();
        bulletLogic.ProjectileSetup(weaponData.projectileVelocity, weaponData.damage);
        Destroy(bullet, weaponData.lifeTime);
    }

    public void OnFire() { isShooting = true; }

    public void OnFireCancelled() { isShooting = false; }

    public void OnShoot() { OnShootEvent.Invoke(); }
}
