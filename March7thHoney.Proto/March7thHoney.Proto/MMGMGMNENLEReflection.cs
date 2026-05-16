using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMGMGMNENLEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMGMGMNENLEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTUdNR01ORU5MRS5wcm90bxoRRU9PQUJCRFBFSkoucHJvdG8aEU9NTE9O" + "R05PTUFJLnByb3RvIk4KC01NR01HTU5FTkxFEiEKC0pQUEdGTEpIREhLGAog" + "ASgLMgwuRU9PQUJCRFBFSkoSHAoGc291cmNlGAwgASgLMgwuT01MT05HTk9N" + "QUlCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[2]
		{
			EOOABBDPEJJReflection.Descriptor,
			OMLONGNOMAIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMGMGMNENLE), MMGMGMNENLE.Parser, new string[2] { "JPPGFLJHDHK", "Source" }, null, null, null, null)
		}));
	}
}
