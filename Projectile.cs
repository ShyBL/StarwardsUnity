// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.44
// 

using Colyseus.Schema;

public partial class Projectile : SpaceObjectBase {
	[Type(9, "float32")]
	public float secondsToLive = default(float);

	[Type(10, "uint16")]
	public ushort health = default(ushort);

	[Type(11, "string")]
	public string targetId = default(string);

	[Type(12, "string")]
	public string model = default(string);
}

