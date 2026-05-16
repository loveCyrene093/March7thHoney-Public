using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DAPDOHOADDBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DAPDOHOADDBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQVBET0hPQUREQi5wcm90byJTCgtEQVBET0hPQUREQhILCgNwb3MYBCAB" + "KA0SEwoLTkxPQ0RITUxHSkgYCCABKA0SDQoFY291bnQYCSABKA0SEwoLQk9G" + "T09LSkNKR0cYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DAPDOHOADDB), DAPDOHOADDB.Parser, new string[4] { "Pos", "NLOCDHMLGJH", "Count", "BOFOOKJCJGG" }, null, null, null, null)
		}));
	}
}
