using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OfferingStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OfferingStateReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNPZmZlcmluZ1N0YXRlLnByb3RvKloKDU9mZmVyaW5nU3RhdGUSFwoTT0ZG" + "RVJJTkdfU1RBVEVfTk9ORRAAEhcKE09GRkVSSU5HX1NUQVRFX0xPQ0sQARIX" + "ChNPRkZFUklOR19TVEFURV9PUEVOEAJCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(OfferingState) }, null, null));
	}
}
