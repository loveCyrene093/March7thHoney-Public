using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFPKEPIAOFPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFPKEPIAOFPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRlBLRVBJQU9GUC5wcm90bxoRRUxMTkRORUJIREsucHJvdG8iMAoLSUZQ" + "S0VQSUFPRlASIQoLRk1FQ0FIQUxQS0cYASABKAsyDC5FTExORE5FQkhES0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ELLNDNEBHDKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IFPKEPIAOFP), IFPKEPIAOFP.Parser, new string[1] { "FMECAHALPKG" }, null, null, null, null)
		}));
	}
}
