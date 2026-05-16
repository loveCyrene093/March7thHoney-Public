using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FEADICKBGGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FEADICKBGGFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRUFESUNLQkdHRi5wcm90bxoRT0JQTVBQQ0ZOTEoucHJvdG8iMAoLRkVB" + "RElDS0JHR0YSIQoLQVBISklBRk9ESEoYBCADKAsyDC5PQlBNUFBDRk5MSkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OBPMPPCFNLJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FEADICKBGGF), FEADICKBGGF.Parser, new string[1] { "APHJIAFODHJ" }, null, null, null, null)
		}));
	}
}
