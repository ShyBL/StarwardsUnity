// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.29
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class SpaceObjectBase : Schema {
	[Type(0, "boolean")]
	public bool destroyed = default(bool);

	[Type(1, "boolean")]
	public bool freeze = default(bool);

	[Type(2, "boolean")]
	public bool expendable = default(bool);

	[Type(3, "string")]
	public string id = default(string);

	[Type(4, "ref", typeof(Vec2))]
	public Vec2 position = new Vec2();

	[Type(5, "float32")]
	public float radius = default(float);

	[Type(6, "ref", typeof(Vec2))]
	public Vec2 velocity = new Vec2();

	[Type(7, "float32")]
	public float angle = default(float);

	[Type(8, "float32")]
	public float turnSpeed = default(float);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<bool> __destroyedChange;
	public Action OnDestroyedChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.destroyed));
		__destroyedChange += __handler;
		if (__immediate && this.destroyed != default(bool)) { __handler(this.destroyed, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(destroyed));
			__destroyedChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __freezeChange;
	public Action OnFreezeChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.freeze));
		__freezeChange += __handler;
		if (__immediate && this.freeze != default(bool)) { __handler(this.freeze, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(freeze));
			__freezeChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __expendableChange;
	public Action OnExpendableChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.expendable));
		__expendableChange += __handler;
		if (__immediate && this.expendable != default(bool)) { __handler(this.expendable, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(expendable));
			__expendableChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __idChange;
	public Action OnIdChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.id));
		__idChange += __handler;
		if (__immediate && this.id != default(string)) { __handler(this.id, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(id));
			__idChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<Vec2> __positionChange;
	public Action OnPositionChange(PropertyChangeHandler<Vec2> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.position));
		__positionChange += __handler;
		if (__immediate && this.position != null) { __handler(this.position, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(position));
			__positionChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __radiusChange;
	public Action OnRadiusChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.radius));
		__radiusChange += __handler;
		if (__immediate && this.radius != default(float)) { __handler(this.radius, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(radius));
			__radiusChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<Vec2> __velocityChange;
	public Action OnVelocityChange(PropertyChangeHandler<Vec2> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.velocity));
		__velocityChange += __handler;
		if (__immediate && this.velocity != null) { __handler(this.velocity, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(velocity));
			__velocityChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __angleChange;
	public Action OnAngleChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.angle));
		__angleChange += __handler;
		if (__immediate && this.angle != default(float)) { __handler(this.angle, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(angle));
			__angleChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __turnSpeedChange;
	public Action OnTurnSpeedChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.turnSpeed));
		__turnSpeedChange += __handler;
		if (__immediate && this.turnSpeed != default(float)) { __handler(this.turnSpeed, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(turnSpeed));
			__turnSpeedChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(destroyed): __destroyedChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(freeze): __freezeChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(expendable): __expendableChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(id): __idChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(position): __positionChange?.Invoke((Vec2) change.Value, (Vec2) change.PreviousValue); break;
			case nameof(radius): __radiusChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(velocity): __velocityChange?.Invoke((Vec2) change.Value, (Vec2) change.PreviousValue); break;
			case nameof(angle): __angleChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(turnSpeed): __turnSpeedChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			default: break;
		}
	}
}

