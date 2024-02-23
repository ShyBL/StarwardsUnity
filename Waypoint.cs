// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.44
// 

using Colyseus.Schema;

public partial class Waypoint : SpaceObjectBase {
	[Type(9, "int8")]
	public sbyte faction = default(sbyte);

	[Type(10, "string")]
	public string owner = default(string);

	[Type(11, "string")]
	public string collection = default(string);

	[Type(12, "string")]
	public string title = default(string);

	[Type(13, "uint32")]
	public uint color = default(uint);
}

