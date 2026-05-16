using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDBCHLBACNDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDBCHLBACNDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFJREJDSExCQUNORC5wcm90byKLAQoLSURCQ0hMQkFDTkQSEwoLQklQSkVI";
		buffer[1] = "SU9FR04YASABKA0SEwoLQkxCR0ZJR0pCTkQYBCABKA0SEwoLSUdJS0tHTE1K";
		buffer[2] = "RUQYCCABKA0SEwoLRkVCSExNTkhGT0MYCSABKA0SEwoLTUtIRE9QR0dCSUUY";
		buffer[3] = "CyABKAgSEwoLUE1JQ0lDUFBET1AYDSABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IDBCHLBACND), IDBCHLBACND.Parser, new string[6] { "BIPJEHIOEGN", "BLBGFIGJBND", "IGIKKGLMJED", "FEBHLMNHFOC", "MKHDOPGGBIE", "PMICICPPDOP" }, null, null, null, null)
		}));
	}
}
