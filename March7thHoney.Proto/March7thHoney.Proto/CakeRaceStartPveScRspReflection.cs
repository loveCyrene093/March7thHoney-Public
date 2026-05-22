using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceStartPveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceStartPveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDYWtlUmFjZVN0YXJ0UHZlU2NSc3AucHJvdG8iPQoVQ2FrZVJhY2VTdGFy" + "dFB2ZVNjUnNwEg8KB3JldGNvZGUYASABKA0SEwoLSkFGTkNPTUdBQkcYCiAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceStartPveScRsp), CakeRaceStartPveScRsp.Parser, new string[2] { "Retcode", "JAFNCOMGABG" }, null, null, null, null)
		}));
	}
}
