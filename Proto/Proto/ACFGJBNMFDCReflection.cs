using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ACFGJBNMFDCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ACFGJBNMFDCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQ0ZHSkJOTUZEQy5wcm90bxoRS0tKTkZJUFBERE8ucHJvdG8iRQoLQUNG" + "R0pCTk1GREMSEwoLTkZPQ05LRkFIT1AYASABKAgSIQoLSkdKQkRBS0FLSEoY" + "CSABKAsyDC5LS0pORklQUERET0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { KKJNFIPPDDOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ACFGJBNMFDC), ACFGJBNMFDC.Parser, new string[2] { "NFOCNKFAHOP", "JGJBDAKAKHJ" }, null, null, null, null)
		}));
	}
}
