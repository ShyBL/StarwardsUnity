// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.29
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Spaceship : SpaceObjectBase {
	[Type(9, "string")]
	public string type = default(string);

	[Type(10, "int8")]
	public sbyte faction = default(sbyte);

	[Type(11, "float32")]
	public float radarRange = default(float);

	[Type(12, "string")]
	public string model = default(string);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<string> __typeChange;
	public Action OnTypeChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.type));
		__typeChange += __handler;
		if (__immediate && this.type != default(string)) { __handler(this.type, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(type));
			__typeChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<sbyte> __factionChange;
	public Action OnFactionChange(PropertyChangeHandler<sbyte> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.faction));
		__factionChange += __handler;
		if (__immediate && this.faction != default(sbyte)) { __handler(this.faction, default(sbyte)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(faction));
			__factionChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __radarRangeChange;
	public Action OnRadarRangeChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.radarRange));
		__radarRangeChange += __handler;
		if (__immediate && this.radarRange != default(float)) { __handler(this.radarRange, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(radarRange));
			__radarRangeChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __modelChange;
	public Action OnModelChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.model));
		__modelChange += __handler;
		if (__immediate && this.model != default(string)) { __handler(this.model, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(model));
			__modelChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(type): __typeChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(faction): __factionChange?.Invoke((sbyte) change.Value, (sbyte) change.PreviousValue); break;
			case nameof(radarRange): __radarRangeChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(model): __modelChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			default: break;
		}
	}
}

