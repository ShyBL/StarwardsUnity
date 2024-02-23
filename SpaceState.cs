// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.44
// 

using Colyseus.Schema;

public partial class SpaceState : Schema {
	[Type(0, "map", typeof(MapSchema<Projectile>))]
	public MapSchema<Projectile> Projectile = new MapSchema<Projectile>();

	[Type(1, "map", typeof(MapSchema<Explosion>))]
	public MapSchema<Explosion> Explosion = new MapSchema<Explosion>();

	[Type(2, "map", typeof(MapSchema<Asteroid>))]
	public MapSchema<Asteroid> Asteroid = new MapSchema<Asteroid>();

	[Type(3, "map", typeof(MapSchema<Spaceship>))]
	public MapSchema<Spaceship> Spaceship = new MapSchema<Spaceship>();

	[Type(4, "map", typeof(MapSchema<Waypoint>))]
	public MapSchema<Waypoint> Waypoint = new MapSchema<Waypoint>();
}

