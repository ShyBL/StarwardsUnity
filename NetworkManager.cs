using System.Collections.Generic;
using UnityEngine;
using Colyseus;

namespace Starwards
{
    public class NetworkManager : MonoBehaviour
    {
        public Dictionary<string, SpaceObjectBase> entities = new ();
        public Dictionary<string, NetworkedEntity> networkedEntities = new ();

        
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
        }
        
        private void Initialize()
        {
            _client = new ColyseusClient(endPoint);
        }

        private void Update()
        {
            if (_spaceRoom != null)
            {
                SpaceRoomUpdate(_spaceRoom.State);
            }
        }

        private void SpaceRoomUpdate(SpaceState state)
        {
            if (state.Asteroid.Count != 0)
            {
                state.Asteroid.ForEach(UpdateObjects);
            }
            
            if (state.Spaceship.Count != 0)
            {
                state.Spaceship.ForEach(UpdateObjects);
            }
            
            if (state.Waypoint.Count != 0)
            {
                
            }
            
            if (state.Projectile.Count != 0)
            {
                
            }
            
            if (state.Explosion.Count != 0)
            {
                
            }
        }

        private void UpdateObjects(string s, SpaceObjectBase spaceObject)
        {
            if (spaceObject.destroyed) return;
            
            if (entities.ContainsKey(spaceObject.id))
            {
                networkedEntities[spaceObject.id].Move();
                Debug.Log($"Moved {s}");
            }
            
            else if (!entities.ContainsKey(spaceObject.id))
            {
                var parentObject = new GameObject();
                parentObject.name = $"{s}";
                var NetworkedEntity = parentObject.AddComponent<NetworkedEntity>();
                
                NetworkedEntity.Init(spaceObject,parentObject);
                Debug.Log($"Spawned {s}");
            }
        }
    }
    
}