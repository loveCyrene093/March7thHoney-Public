using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MFHOJCCILLCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MFHOJCCILLCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRkhPSkNDSUxMQy5wcm90byJdCgtNRkhPSkNDSUxMQxITCgtERklCTEpJ" + "SExHTBgIIAEoDRITCgtGRUtJT0hPSkJIRRgJIAEoDRITCgtMRUhPQkZGTUdC" + "TBgNIAEoDRIPCgdhcmVhX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MFHOJCCILLC), MFHOJCCILLC.Parser, new string[4] { "DFIBLJIHLGL", "FEKIOHOJBHE", "LEHOBFFMGBL", "AreaId" }, null, null, null, null)
		}));
	}
}
