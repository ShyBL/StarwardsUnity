// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.29
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class AdminState : Schema {
	[Type(0, "int8")]
	public sbyte gameStatus = default(sbyte);

	[Type(1, "array", typeof(ArraySchema<string>), "string")]
	public ArraySchema<string> shipIds = new ArraySchema<string>();

	[Type(2, "array", typeof(ArraySchema<string>), "string")]
	public ArraySchema<string> playerShipIds = new ArraySchema<string>();

	[Type(3, "float32")]
	public float speed = default(float);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<sbyte> __gameStatusChange;
	public Action OnGameStatusChange(PropertyChangeHandler<sbyte> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.gameStatus));
		__gameStatusChange += __handler;
		if (__immediate && this.gameStatus != default(sbyte)) { __handler(this.gameStatus, default(sbyte)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(gameStatus));
			__gameStatusChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<ArraySchema<string>> __shipIdsChange;
	public Action OnShipIdsChange(PropertyChangeHandler<ArraySchema<string>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.shipIds));
		__shipIdsChange += __handler;
		if (__immediate && this.shipIds != null) { __handler(this.shipIds, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(shipIds));
			__shipIdsChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<ArraySchema<string>> __playerShipIdsChange;
	public Action OnPlayerShipIdsChange(PropertyChangeHandler<ArraySchema<string>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.playerShipIds));
		__playerShipIdsChange += __handler;
		if (__immediate && this.playerShipIds != null) { __handler(this.playerShipIds, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(playerShipIds));
			__playerShipIdsChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __speedChange;
	public Action OnSpeedChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.speed));
		__speedChange += __handler;
		if (__immediate && this.speed != default(float)) { __handler(this.speed, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(speed));
			__speedChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(gameStatus): __gameStatusChange?.Invoke((sbyte) change.Value, (sbyte) change.PreviousValue); break;
			case nameof(shipIds): __shipIdsChange?.Invoke((ArraySchema<string>) change.Value, (ArraySchema<string>) change.PreviousValue); break;
			case nameof(playerShipIds): __playerShipIdsChange?.Invoke((ArraySchema<string>) change.Value, (ArraySchema<string>) change.PreviousValue); break;
			case nameof(speed): __speedChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			default: break;
		}
	}
}

