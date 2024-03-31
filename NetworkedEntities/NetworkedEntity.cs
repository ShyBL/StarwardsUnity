using System;
using System.Collections.Generic;
using UnityEngine;
using Colyseus;
using Colyseus.Schema;
using Object = UnityEngine.Object;

namespace Starwards
{
    public class NetworkedEntity : MonoBehaviour
    {
        public void Init(SpaceObjectBase state, Object prefab, GameObject parent)
        {
            switch (state)
            {
                case Asteroid asteroid:
                    Instantiate(prefab,new Vector3(asteroid.position.x,asteroid.position.x),Quaternion.identity);
                    NetworkManager.Instance.entities.Add(asteroid.id,asteroid);
                    break;
                case Explosion explosion:
                    Instantiate(prefab,new Vector3(explosion.position.x,explosion.position.x),Quaternion.identity);
                    NetworkManager.Instance.entities.Add(explosion.id,explosion);
                    break;
                case Projectile projectile:
                    Instantiate(prefab,new Vector3(projectile.position.x,projectile.position.x),Quaternion.identity);
                    NetworkManager.Instance.entities.Add(projectile.id,projectile);
                    break;
                case Spaceship spaceship:
                    Instantiate(prefab,new Vector3(spaceship.position.x,spaceship.position.x),Quaternion.identity);
                    NetworkManager.Instance.entities.Add(spaceship.id,spaceship);
                    break;
                case Waypoint waypoint:
                    Instantiate(prefab,new Vector3(waypoint.position.x,waypoint.position.x),Quaternion.identity);
                    NetworkManager.Instance.entities.Add(waypoint.id,waypoint);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(state));
            }
            
            gameObject.transform.SetParent(parent.transform);
        }
        public void Move()
        {
            
        }
        
    }
}