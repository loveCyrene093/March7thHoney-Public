using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CDHOKMAAMFDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CDHOKMAAMFDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDREhPS01BQU1GRC5wcm90bxoRSVBKT0pLUEJGR0sucHJvdG8aEUpDSkFD" + "S0lDUEhOLnByb3RvIlMKC0NESE9LTUFBTUZEEiEKC0ROQ05QTkJMRU5GGAIg" + "AygLMgwuSVBKT0pLUEJGR0sSIQoLRkVESkpCQkhDQ0cYDCADKAsyDC5KQ0pB" + "Q0tJQ1BITkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			IPJOJKPBFGKReflection.Descriptor,
			JCJACKICPHNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CDHOKMAAMFD), CDHOKMAAMFD.Parser, new string[2] { "DNCNPNBLENF", "FEDJJBBHCCG" }, null, null, null, null)
		}));
	}
}
