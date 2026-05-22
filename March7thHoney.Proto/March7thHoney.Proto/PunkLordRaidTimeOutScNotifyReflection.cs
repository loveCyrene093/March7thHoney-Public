using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PunkLordRaidTimeOutScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PunkLordRaidTimeOutScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFQdW5rTG9yZFJhaWRUaW1lT3V0U2NOb3RpZnkucHJvdG8aHlB1bmtMb3Jk" + "TW9uc3RlckJhc2ljSW5mby5wcm90byJNChtQdW5rTG9yZFJhaWRUaW1lT3V0" + "U2NOb3RpZnkSLgoLRkZDRFBITUpKS0cYAyABKAsyGS5QdW5rTG9yZE1vbnN0" + "ZXJCYXNpY0luZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { PunkLordMonsterBasicInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordRaidTimeOutScNotify), PunkLordRaidTimeOutScNotify.Parser, new string[1] { "FFCDPHMJJKG" }, null, null, null, null)
		}));
	}
}
