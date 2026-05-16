using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HKJECENOHBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HKJECENOHBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIS0pFQ0VOT0hCSS5wcm90bxoRTkJLQkNOR0FJTkUucHJvdG8iMAoLSEtK" + "RUNFTk9IQkkSIQoLTEJQSFBQTlBLREMYAiADKAsyDC5OQktCQ05HQUlORUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NBKBCNGAINEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HKJECENOHBI), HKJECENOHBI.Parser, new string[1] { "LBPHPPNPKDC" }, null, null, null, null)
		}));
	}
}
