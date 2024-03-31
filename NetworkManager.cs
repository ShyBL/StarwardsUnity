using System;
using System.Collections.Generic;
using UnityEngine;
using Colyseus;
using Colyseus.Schema;
using UnityEngine.Serialization;

namespace Starwards
{
    public class NetworkManager : MonoBehaviour
    {
        public GameObject AsteroidPrefab;
        public GameObject SpaceshipPrefab;
        public GameObject WaypointPrefab;
        public Dictionary<string, SpaceObjectBase> entities;
        public Dictionary<string, NetworkedEntity> networkedEntities;

        
        private static ColyseusClient _client = null;
        private static ColyseusRoom<SpaceState> _spaceRoom = null;

        public string endPoint = "ws://localhost:80";
        public string adminRoomName = "admin";
        public string spaceRoomName = "space";
        public string shipRoomName = "ship";

        public static NetworkManager Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            
            else
            {
                Debug.LogError($"Two {typeof(NetworkManager)} instances exist, didn't create new one");
            }
        }

        private async void Start()
        {
            Initialize();
            _spaceRoom = await _client.Join<SpaceState>(spaceRoomName);
            Debug.Log($"connected: {_spaceRoom.RoomId}");

            _spaceRoom.OnStateChange += SpaceRoomSetup;
        }
        
        private void Initialize()
        {
            _client = new ColyseusClient(endPoint);
        }

        private void SpaceRoomSetup(SpaceState state, bool isFirstState)
        {
            if (state.Asteroid.Count != 0)
            {
                state.Asteroid.ForEach(SpawnAsteroids);
            }
            
            if (state.Spaceship.Count != 0)
            {
                state.Spaceship.ForEach(SpawnSpaceship);
                
            }
            
            if (state.Waypoint.Count != 0)
            {
                //state.Waypoint.ForEach(SpawnWaypoints);
            }
            
            if (state.Projectile.Count != 0)
            {
                
            }
            
            if (state.Explosion.Count != 0)
            {
                
            }
        }

        private void SpawnWaypoints(string s, Waypoint waypoint)
        {
            if (waypoint.destroyed) return;
            
            if (entities.ContainsKey(waypoint.id))
            {
                networkedEntities[waypoint.id].Move();
                Debug.Log($"Moved {s}");

            }
            
<<<<<<< Updated upstream
            if (state.Spaceship.Count != 0)
            {
                foreach (KeyValuePair<string, object> obj in state.Spaceship.items.AsDictionary())
                {
                    SpaceObjectBase spaceship = (SpaceObjectBase)obj.Value;
                    if (spaceship.destroyed) continue;
                    Instantiate(SpaceshipPrefab, new Vector3(spaceship.position.x, spaceship.position.y),Quaternion.identity);
                }
            }
            
            if (state.Waypoint.Count != 0)
=======
            else if (!entities.ContainsKey(waypoint.id))
>>>>>>> Stashed changes
            {
                var parentObject = new GameObject();
                var Waypoint = parentObject.AddComponent<NetworkedEntity>();
                
                Waypoint.Init(waypoint,WaypointPrefab,parentObject);
                Debug.Log($"Spawned {s}");
            }
        }
        private void SpawnAsteroids(string s, Asteroid asteroid)
        {
            if (asteroid.destroyed) return;
            
            if (entities.ContainsKey(asteroid.id))
            {
                networkedEntities[asteroid.id].Move();
                Debug.Log($"Moved {s}");

            }
            
            else if (!entities.ContainsKey(asteroid.id))
            {
                var parentObject = new GameObject();
                var Asteroid = parentObject.AddComponent<NetworkedEntity>();
                
                Asteroid.Init(asteroid,AsteroidPrefab,parentObject);
                Debug.Log($"Spawned {s}");
            }
        }

        private void SpawnSpaceship(string s, Spaceship spaceship)
        {
            if (spaceship.destroyed) return;
            
            if (entities.ContainsKey(spaceship.id))
            {
                networkedEntities[spaceship.id].Move();
                Debug.Log($"Moved {s}");

            }
            
            else if (!entities.ContainsKey(spaceship.id))
            {
                var parentObject = new GameObject();
                var Spaceship = parentObject.AddComponent<NetworkedEntity>();
                
                Spaceship.Init(spaceship,WaypointPrefab,parentObject);
                Debug.Log($"Spawned {s}");
            }
        }
    }
<<<<<<< Updated upstream
}
=======
    
}
>>>>>>> Stashed changes
