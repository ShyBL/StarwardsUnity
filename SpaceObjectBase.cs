// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.44
// 

using Colyseus.Schema;

public partial class SpaceObjectBase : Schema {
	[Type(0, "string")]
	public string type = default(string);

	[Type(1, "boolean")]
	public bool destroyed = default(bool);

	[Type(2, "boolean")]
	public bool freeze = default(bool);

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
}

