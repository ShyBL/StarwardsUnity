// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.29
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Explosion : SpaceObjectBase {
	[Type(9, "float32")]
	public float secondsToLive = default(float);

	[Type(10, "float32")]
	public float expansionSpeed = default(float);

	[Type(11, "float32")]
	public float damageFactor = default(float);

	[Type(12, "float32")]
	public float blastFactor = default(float);

	[Type(13, "string")]
	public string type = default(string);

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

	protected event PropertyChangeHandler<float> __expansionSpeedChange;
	public Action OnExpansionSpeedChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.expansionSpeed));
		__expansionSpeedChange += __handler;
		if (__immediate && this.expansionSpeed != default(float)) { __handler(this.expansionSpeed, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(expansionSpeed));
			__expansionSpeedChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __damageFactorChange;
	public Action OnDamageFactorChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.damageFactor));
		__damageFactorChange += __handler;
		if (__immediate && this.damageFactor != default(float)) { __handler(this.damageFactor, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(damageFactor));
			__damageFactorChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __blastFactorChange;
	public Action OnBlastFactorChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.blastFactor));
		__blastFactorChange += __handler;
		if (__immediate && this.blastFactor != default(float)) { __handler(this.blastFactor, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(blastFactor));
			__blastFactorChange -= __handler;
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

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(secondsToLive): __secondsToLiveChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(expansionSpeed): __expansionSpeedChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(damageFactor): __damageFactorChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(blastFactor): __blastFactorChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(type): __typeChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			default: break;
		}
	}
}

