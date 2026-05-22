using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenRogueChestCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenRogueChestCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlPcGVuUm9ndWVDaGVzdENzUmVxLnByb3RvIk0KE09wZW5Sb2d1ZUNoZXN0" + "Q3NSZXESIQoZaW50ZXJhY3RlZF9wcm9wX2VudGl0eV9pZBgCIAEoDRITCgtO" + "QkRIQURQTkdOSBgFIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenRogueChestCsReq), OpenRogueChestCsReq.Parser, new string[2] { "InteractedPropEntityId", "NBDHADPNGNH" }, null, null, null, null)
		}));
	}
}
