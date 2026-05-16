using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateFeatureSwitchScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateFeatureSwitchScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFVcGRhdGVGZWF0dXJlU3dpdGNoU2NOb3RpZnkucHJvdG8aEUNFTk9JRU1K" + "UEtLLnByb3RvIkUKG1VwZGF0ZUZlYXR1cmVTd2l0Y2hTY05vdGlmeRImChBz" + "d2l0Y2hfaW5mb19saXN0GAYgAygLMgwuQ0VOT0lFTUpQS0tCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { CENOIEMJPKKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateFeatureSwitchScNotify), UpdateFeatureSwitchScNotify.Parser, new string[1] { "SwitchInfoList" }, null, null, null, null)
		}));
	}
}
