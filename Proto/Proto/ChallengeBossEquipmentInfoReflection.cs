using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossEquipmentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossEquipmentInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDaGFsbGVuZ2VCb3NzRXF1aXBtZW50SW5mby5wcm90byJsChpDaGFsbGVu" + "Z2VCb3NzRXF1aXBtZW50SW5mbxINCgVsZXZlbBgBIAEoDRIRCglwcm9tb3Rp" + "b24YAiABKA0SDAoEcmFuaxgHIAEoDRILCgN0aWQYDSABKA0SEQoJdW5pcXVl" + "X2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossEquipmentInfo), ChallengeBossEquipmentInfo.Parser, new string[5] { "Level", "Promotion", "Rank", "Tid", "UniqueId" }, null, null, null, null)
		}));
	}
}
