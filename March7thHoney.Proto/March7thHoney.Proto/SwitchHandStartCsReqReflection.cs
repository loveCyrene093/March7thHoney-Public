using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandStartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandStartCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTd2l0Y2hIYW5kU3RhcnRDc1JlcS5wcm90byIpChRTd2l0Y2hIYW5kU3Rh" + "cnRDc1JlcRIRCgljb25maWdfaWQYBSABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandStartCsReq), SwitchHandStartCsReq.Parser, new string[1] { "ConfigId" }, null, null, null, null)
		}));
	}
}
