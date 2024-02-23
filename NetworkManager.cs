using System.Collections.Generic;
using UnityEngine;
using Colyseus;

namespace Starwards
{
    public class NetworkManager : MonoBehaviour
    {
        public GameObject AsteroidPrefab;
        public GameObject SpaceshipPrefab;
        
        private static ColyseusClient _client = null;
        private static ColyseusRoom<SpaceState> _spaceRoom = null;

        public string endPoint = "ws://localhost:80";
        public string adminRoomName = "admin";
        public string spaceRoomName = "space";
        public string shipRoomName = "ship";
        
        private async void Start()
        {
            Initialize();
            _spaceRoom = await _client.Join<SpaceState>(spaceRoomName);
            Debug.Log($"connected: {_spaceRoom.Id}");

            _spaceRoom.OnStateChange += SpaceRoomSetup;
        }
        
        private void Initialize()
        {
            _client = new ColyseusClient(endPoint);
        }

        private void SpaceRoomSetup(SpaceState state, bool isFirstState)
        {
            if (state.Projectile.Count != 0)
            {
                
            }
            
            if (state.Explosion.Count != 0)
            {
                
            }
            
            if (state.Asteroid.Count != 0)
            {
                foreach (KeyValuePair<string, object> obj in state.Asteroid.items.AsDictionary())
                {
                    SpaceObjectBase asteroid = (SpaceObjectBase)obj.Value;
                    if (asteroid.destroyed) continue;
                    Instantiate(AsteroidPrefab, new Vector3(asteroid.position.x, asteroid.position.y),Quaternion.identity);
                }
            }
            
            if (state.Spaceship.Count != 0)
            {
                foreach (var obj in state.Spaceship.items.AsDictionary())
                {
                    SpaceObjectBase spaceship = (SpaceObjectBase)obj.Value;
                    if (spaceship.destroyed) continue;
                    Instantiate(SpaceshipPrefab, new Vector3(spaceship.position.x, spaceship.position.y),Quaternion.identity);
                }
            }
            
            if (state.Waypoint.Count != 0)
            {
                
            }
        }
    }
}