// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.44
// 

using Colyseus.Schema;

public partial class Explosion : SpaceObjectBase {
	[Type(9, "float32")]
	public float secondsToLive = default(float);

	[Type(10, "float32")]
	public float expansionSpeed = default(float);

	[Type(11, "float32")]
	public float damageFactor = default(float);

	[Type(12, "float32")]
	public float blastFactor = default(float);
}

