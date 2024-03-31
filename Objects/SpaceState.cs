// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.29
// 

using Colyseus.Schema;
using Action = System.Action;

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

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<MapSchema<Projectile>> __ProjectileChange;
	public Action OnProjectileChange(PropertyChangeHandler<MapSchema<Projectile>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.Projectile));
		__ProjectileChange += __handler;
		if (__immediate && this.Projectile != null) { __handler(this.Projectile, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(Projectile));
			__ProjectileChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<Explosion>> __ExplosionChange;
	public Action OnExplosionChange(PropertyChangeHandler<MapSchema<Explosion>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.Explosion));
		__ExplosionChange += __handler;
		if (__immediate && this.Explosion != null) { __handler(this.Explosion, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(Explosion));
			__ExplosionChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<Asteroid>> __AsteroidChange;
	public Action OnAsteroidChange(PropertyChangeHandler<MapSchema<Asteroid>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.Asteroid));
		__AsteroidChange += __handler;
		if (__immediate && this.Asteroid != null) { __handler(this.Asteroid, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(Asteroid));
			__AsteroidChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<Spaceship>> __SpaceshipChange;
	public Action OnSpaceshipChange(PropertyChangeHandler<MapSchema<Spaceship>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.Spaceship));
		__SpaceshipChange += __handler;
		if (__immediate && this.Spaceship != null) { __handler(this.Spaceship, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(Spaceship));
			__SpaceshipChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<Waypoint>> __WaypointChange;
	public Action OnWaypointChange(PropertyChangeHandler<MapSchema<Waypoint>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.Waypoint));
		__WaypointChange += __handler;
		if (__immediate && this.Waypoint != null) { __handler(this.Waypoint, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(Waypoint));
			__WaypointChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(Projectile): __ProjectileChange?.Invoke((MapSchema<Projectile>) change.Value, (MapSchema<Projectile>) change.PreviousValue); break;
			case nameof(Explosion): __ExplosionChange?.Invoke((MapSchema<Explosion>) change.Value, (MapSchema<Explosion>) change.PreviousValue); break;
			case nameof(Asteroid): __AsteroidChange?.Invoke((MapSchema<Asteroid>) change.Value, (MapSchema<Asteroid>) change.PreviousValue); break;
			case nameof(Spaceship): __SpaceshipChange?.Invoke((MapSchema<Spaceship>) change.Value, (MapSchema<Spaceship>) change.PreviousValue); break;
			case nameof(Waypoint): __WaypointChange?.Invoke((MapSchema<Waypoint>) change.Value, (MapSchema<Waypoint>) change.PreviousValue); break;
			default: break;
		}
	}
}

