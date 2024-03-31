// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.29
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Projectile : SpaceObjectBase {
	[Type(9, "float32")]
	public float secondsToLive = default(float);

	[Type(10, "string")]
	public string type = default(string);

	[Type(11, "uint16")]
	public ushort health = default(ushort);

	[Type(12, "string")]
	public string targetId = default(string);

	[Type(13, "string")]
	public string model = default(string);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<float> __secondsToLiveChange;
	public Action OnSecondsToLiveChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.secondsToLive));
		__secondsToLiveChange += __handler;
		if (__immediate && this.secondsToLive != default(float)) { __handler(this.secondsToLive, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(secondsToLive));
			__secondsToLiveChange -= __handler;
		};
	}

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

	protected event PropertyChangeHandler<ushort> __healthChange;
	public Action OnHealthChange(PropertyChangeHandler<ushort> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.health));
		__healthChange += __handler;
		if (__immediate && this.health != default(ushort)) { __handler(this.health, default(ushort)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(health));
			__healthChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __targetIdChange;
	public Action OnTargetIdChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.targetId));
		__targetIdChange += __handler;
		if (__immediate && this.targetId != default(string)) { __handler(this.targetId, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(targetId));
			__targetIdChange -= __handler;
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
			case nameof(secondsToLive): __secondsToLiveChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(type): __typeChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(health): __healthChange?.Invoke((ushort) change.Value, (ushort) change.PreviousValue); break;
			case nameof(targetId): __targetIdChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(model): __modelChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			default: break;
		}
	}
}

