
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float dam = 10f;
    public float dist = 100f;

    public Camera fpscam;
    public ParticleSystem muzzleflash;
    public GameObject inpactEffect;
  
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }
    void Shoot()
    {
        muzzleflash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, dist))
        {
            EnemyDamage Damage = hit.transform.GetComponent<EnemyDamage>();
            if(Damage != null)
            {
                Damage.TakeDamage(dam);
            }

           GameObject inpactGO = Instantiate(inpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(inpactGO, 2f);
        }

    }
}
