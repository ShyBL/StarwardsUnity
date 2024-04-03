using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Starwards
{
    public class NetworkedEntity : MonoBehaviour
    {
        public void Init(SpaceObjectBase state, GameObject parent)
        {
            switch (state)
            {
                case Spaceship spaceship:
                    var Spaceship = (GameObject)Instantiate(Resources.Load("SpaceshipPrefab"),new Vector3(spaceship.position.x,spaceship.position.y),Quaternion.identity);
                    Spaceship.transform.SetParent(parent.transform);
                    
                    NetworkManager.Instance.entities.Add(spaceship.id,spaceship);
                    NetworkManager.Instance.networkedEntities.Add(spaceship.id,this);

                    if (spaceship.faction == 0)
                    {
                        Camera.main.transform.SetParent(Spaceship.transform);
                    }
                    
                    break;
                
                case Asteroid asteroid:
                    var Asteroid = (GameObject)Instantiate(Resources.Load("AsteroidPrefab"),new Vector3(asteroid.position.x,asteroid.position.x),Quaternion.identity);
                    Asteroid.transform.SetParent(parent.transform);
                    
                    NetworkManager.Instance.entities.Add(asteroid.id,asteroid);
                    NetworkManager.Instance.networkedEntities.Add(asteroid.id,this);
                    break;
                
                case Explosion explosion:
                    var Explosion = (GameObject)Instantiate(Resources.Load("ExplosionPrefab"),new Vector3(explosion.position.x,explosion.position.x),Quaternion.identity);
                    Explosion.transform.SetParent(parent.transform);
                    
                    NetworkManager.Instance.entities.Add(explosion.id,explosion);
                    NetworkManager.Instance.networkedEntities.Add(explosion.id,this);
                    break;
                
                case Projectile projectile:
                    var Projectile = (GameObject)Instantiate(Resources.Load("ProjectilePrefab"),new Vector3(projectile.position.x,projectile.position.x),Quaternion.identity);
                    Projectile.transform.SetParent(parent.transform);
                    
                    NetworkManager.Instance.entities.Add(projectile.id,projectile);
                    NetworkManager.Instance.networkedEntities.Add(projectile.id,this);
                    break;
                
                case Waypoint waypoint:
                    var Waypoint = (GameObject)Instantiate(Resources.Load("WaypointPrefab"),new Vector3(waypoint.position.x,waypoint.position.x),Quaternion.identity);
                    Waypoint.transform.SetParent(parent.transform);
                    
                    NetworkManager.Instance.entities.Add(waypoint.id,waypoint);
                    NetworkManager.Instance.networkedEntities.Add(waypoint.id,this);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(state));
            }
        }
        public void Move()
        {
            
        }
        
    }
}