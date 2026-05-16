using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AlleyPlacingShipReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AlleyPlacingShipReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBbGxleVBsYWNpbmdTaGlwLnByb3RvGhFKTURER09HTkJFSy5wcm90byJF" + "ChBBbGxleVBsYWNpbmdTaGlwEiAKCmdvb2RzX2xpc3QYASADKAsyDC5KTURE" + "R09HTkJFSxIPCgdzaGlwX2lkGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { JMDDGOGNBEKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AlleyPlacingShip), AlleyPlacingShip.Parser, new string[2] { "GoodsList", "ShipId" }, null, null, null, null)
		}));
	}
}
