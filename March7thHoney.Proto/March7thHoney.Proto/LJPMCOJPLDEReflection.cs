using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LJPMCOJPLDEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LJPMCOJPLDEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSlBNQ09KUExERS5wcm90bxoRTkFEQ05BTkpMQkoucHJvdG8iQQoLTEpQ" + "TUNPSlBMREUSIQoLSUlQQkNJUE5IQ0kYBSADKAsyDC5OQURDTkFOSkxCShIP" + "CgdyZXRjb2RlGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { NADCNANJLBJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LJPMCOJPLDE), LJPMCOJPLDE.Parser, new string[2] { "IIPBCIPNHCI", "Retcode" }, null, null, null, null)
		}));
	}
}
