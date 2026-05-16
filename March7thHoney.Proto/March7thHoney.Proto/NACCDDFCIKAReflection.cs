using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NACCDDFCIKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NACCDDFCIKAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQUNDRERGQ0lLQS5wcm90bxoZVHJhaW5QYXJ0eVBhc3Nlbmdlci5wcm90" + "byI4CgtOQUNDRERGQ0lLQRIpCgtBSUpOR0VGT0FETBgKIAEoCzIULlRyYWlu" + "UGFydHlQYXNzZW5nZXJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { TrainPartyPassengerReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NACCDDFCIKA), NACCDDFCIKA.Parser, new string[1] { "AIJNGEFOADL" }, null, null, null, null)
		}));
	}
}
