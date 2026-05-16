using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GLKPCPLBPLNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GLKPCPLBPLNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTEtQQ1BMQlBMTi5wcm90bxoRT0xKSkpCQ0tMREsucHJvdG8iVgoLR0xL" + "UENQTEJQTE4SDwoHcmV0Y29kZRgCIAEoDRIhCgtBR0ZQRk9EUE9GQRgMIAEo" + "CzIMLk9MSkpKQkNLTERLEhMKC0RBSUtOS0FMS0NNGA4gASgIQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { OLJJJBCKLDKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GLKPCPLBPLN), GLKPCPLBPLN.Parser, new string[3] { "Retcode", "AGFPFODPOFA", "DAIKNKALKCM" }, null, null, null, null)
		}));
	}
}
