using System;
using UnityEngine;

    public class NetworkedEntity : MonoBehaviour
    {
        public void Init(SpaceObjectBase state, GameObject parent)
        {
            switch (state)
            {
                case Spaceship spaceship:
                    
                    if (spaceship.id == "")
                    {
                        var Spaceship = (GameObject)Instantiate(Resources.Load("PlayerPrefab"),NewPosition(spaceship),Quaternion.identity);
                        Spaceship.transform.SetParent(parent.transform);
                    }
                    if (spaceship.id == "")
                    {
                        var Spaceship = (GameObject)Instantiate(Resources.Load("SpaceshipPrefab"),NewPosition(spaceship),Quaternion.identity);
                        Spaceship.transform.SetParent(parent.transform);
                    }
                    
                    AddToControlList(spaceship);
                    break;
                
                case Asteroid asteroid:
                    
                    var Asteroid = (GameObject)Instantiate(Resources.Load("AsteroidPrefab"), NewPosition(asteroid),Quaternion.identity);
                    Asteroid.transform.SetParent(parent.transform);
                    
                    AddToControlList(asteroid);
                    break;
                
                case Explosion explosion:
                case Projectile projectile:
                case Waypoint waypoint:
                    
                    // var Waypoint = (GameObject)Instantiate(Resources.Load("WaypointPrefab"),new Vector3(waypoint.position.x,waypoint.position.x),Quaternion.identity);
                    // Waypoint.transform.SetParent(parent.transform);
                    //AddToControlList(waypoint);
                    break;
            }
        }

        private Vector3 NewPosition(SpaceObjectBase spaceObject)
        {
            var newPos = new Vector3(spaceObject.position.x, 0, spaceObject.position.y);
            return newPos;
        }
        private void AddToControlList(SpaceObjectBase spaceObject)
        {
            NetworkManager.Instance.Entities.Add(spaceObject.id, spaceObject);
            NetworkManager.Instance.NetworkedEntities.Add(spaceObject.id, this);
        }

        public void Move(SpaceObjectBase spaceObject)
        {
            gameObject.transform.position = new Vector3(spaceObject.position.x,spaceObject.position.y, 0);
            
            var deg = spaceObject.angle;
            
            Quaternion target = Quaternion.Euler(0,deg,0);
            
            gameObject.transform.localRotation = target;


        }
    }
