// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.44
// 

using Colyseus.Schema;

public partial class Spaceship : SpaceObjectBase {
	[Type(9, "int8")]
	public sbyte faction = default(sbyte);

	[Type(10, "float32")]
	public float radarRange = default(float);

	[Type(11, "string")]
	public string model = default(string);
}

