using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGachaDecideItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGachaDecideItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TZXRHYWNoYURlY2lkZUl0ZW1Dc1JlcS5wcm90byJVChdTZXRHYWNoYURl" + "Y2lkZUl0ZW1Dc1JlcRIQCghnYWNoYV9pZBgCIAEoDRITCgtNQk9FRkxBSExF" + "TRgEIAEoDRITCgtER09NSERNSkhFSxgMIAMoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGachaDecideItemCsReq), SetGachaDecideItemCsReq.Parser, new string[3] { "GachaId", "MBOEFLAHLEM", "DGOMHDMJHEK" }, null, null, null, null)
		}));
	}
}
