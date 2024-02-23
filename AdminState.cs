// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.44
// 

using Colyseus.Schema;

public partial class AdminState : Schema {
	[Type(0, "boolean")]
	public bool isGameRunning = default(bool);

	[Type(1, "array", typeof(ArraySchema<string>), "string")]
	public ArraySchema<string> shipIds = new ArraySchema<string>();

	[Type(2, "float32")]
	public float speed = default(float);
}

