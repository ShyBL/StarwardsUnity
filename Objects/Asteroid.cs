// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.29
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Asteroid : SpaceObjectBase {
	[Type(9, "string")]
	public string type = default(string);

	[Type(10, "uint16")]
	public ushort health = default(ushort);

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

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(type): __typeChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(health): __healthChange?.Invoke((ushort) change.Value, (ushort) change.PreviousValue); break;
			default: break;
		}
	}
}

