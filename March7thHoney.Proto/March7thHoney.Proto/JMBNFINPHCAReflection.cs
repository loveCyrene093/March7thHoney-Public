using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JMBNFINPHCAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JMBNFINPHCAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTUJORklOUEhDQS5wcm90bxoRSkZOQUFGTkxITlAucHJvdG8iMAoLSk1C" + "TkZJTlBIQ0ESIQoLTlBDRUNNSkdJTEIYBCADKAsyDC5KRk5BQUZOTEhOUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JFNAAFNLHNPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JMBNFINPHCA), JMBNFINPHCA.Parser, new string[1] { "NPCECMJGILB" }, null, null, null, null)
		}));
	}
}
