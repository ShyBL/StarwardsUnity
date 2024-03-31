// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.29
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Waypoint : SpaceObjectBase {
	[Type(9, "string")]
	public string type = default(string);

	[Type(10, "int8")]
	public sbyte faction = default(sbyte);

	[Type(11, "string")]
	public string owner = default(string);

	[Type(12, "string")]
	public string collection = default(string);

	[Type(13, "string")]
	public string title = default(string);

	[Type(14, "uint32")]
	public uint color = default(uint);

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

	protected event PropertyChangeHandler<string> __ownerChange;
	public Action OnOwnerChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.owner));
		__ownerChange += __handler;
		if (__immediate && this.owner != default(string)) { __handler(this.owner, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(owner));
			__ownerChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __collectionChange;
	public Action OnCollectionChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.collection));
		__collectionChange += __handler;
		if (__immediate && this.collection != default(string)) { __handler(this.collection, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(collection));
			__collectionChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __titleChange;
	public Action OnTitleChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.title));
		__titleChange += __handler;
		if (__immediate && this.title != default(string)) { __handler(this.title, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(title));
			__titleChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<uint> __colorChange;
	public Action OnColorChange(PropertyChangeHandler<uint> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.color));
		__colorChange += __handler;
		if (__immediate && this.color != default(uint)) { __handler(this.color, default(uint)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(color));
			__colorChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(type): __typeChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(faction): __factionChange?.Invoke((sbyte) change.Value, (sbyte) change.PreviousValue); break;
			case nameof(owner): __ownerChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(collection): __collectionChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(title): __titleChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(color): __colorChange?.Invoke((uint) change.Value, (uint) change.PreviousValue); break;
			default: break;
		}
	}
}

