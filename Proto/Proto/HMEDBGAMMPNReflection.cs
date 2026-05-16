using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HMEDBGAMMPNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HMEDBGAMMPNReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFITUVEQkdBTU1QTi5wcm90byK0AQoLSE1FREJHQU1NUE4SMgoLQk9MRUhJ";
		buffer[1] = "TEtLQU8YBiADKAsyHS5ITUVEQkdBTU1QTi5CT0xFSElMS0tBT0VudHJ5EhMK";
		buffer[2] = "C09LT05GR09QT09LGAcgASgNEhMKC0RBQ09LRkNCTUJJGAggASgNEhMKC01H";
		buffer[3] = "Q1BJUENHSUxPGA0gAygNGjIKEEJPTEVISUxLS0FPRW50cnkSCwoDa2V5GAEg";
		buffer[4] = "ASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[5] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HMEDBGAMMPN), HMEDBGAMMPN.Parser, new string[4] { "BOLEHILKKAO", "OKONFGOPOOK", "DACOKFCBMBI", "MGCPIPCGILO" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
