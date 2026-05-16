using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PreCheckEnterRoomReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PreCheckEnterRoomReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQcmVDaGVja0VudGVyUm9vbVJlcS5wcm90bxoRRkVETEtBTkZOQkgucHJv" + "dG8iYAoUUHJlQ2hlY2tFbnRlclJvb21SZXESEwoLdGVsZXBvcnRfaWQYAiAB" + "KA0SEAoIZW50cnlfaWQYBSABKA0SIQoLUExPQk1CRlBORksYDiABKA4yDC5G" + "RURMS0FORk5CSEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FEDLKANFNBHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PreCheckEnterRoomReq), PreCheckEnterRoomReq.Parser, new string[3] { "TeleportId", "EntryId", "PLOBMBFPNFK" }, null, null, null, null)
		}));
	}
}
