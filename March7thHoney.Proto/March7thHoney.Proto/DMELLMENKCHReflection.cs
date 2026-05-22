using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DMELLMENKCHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DMELLMENKCHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETUVMTE1FTktDSC5wcm90bxoRSkFNTEhPSEJJR0IucHJvdG8iVgoLRE1F" + "TExNRU5LQ0gSDwoHcmV0Y29kZRgFIAEoDRITCgt1c2VfaXRlbV9pZBgGIAEo" + "DRIhCgtFTkJHTkxCTUdGSxgPIAEoCzIMLkpBTUxIT0hCSUdCQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { JAMLHOHBIGBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DMELLMENKCH), DMELLMENKCH.Parser, new string[3] { "Retcode", "UseItemId", "ENBGNLBMGFK" }, null, null, null, null)
		}));
	}
}
