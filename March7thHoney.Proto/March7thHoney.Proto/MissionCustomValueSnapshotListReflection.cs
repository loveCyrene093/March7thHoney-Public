using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionCustomValueSnapshotListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionCustomValueSnapshotListReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiRNaXNzaW9uQ3VzdG9tVmFsdWVTbmFwc2hvdExpc3QucHJvdG8aIE1pc3Np";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b25DdXN0b21WYWx1ZVNuYXBzaG90LnByb3RvIlgKHk1pc3Npb25DdXN0b21W";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YWx1ZVNuYXBzaG90TGlzdBI2ChFjdXN0b21fdmFsdWVfbGlzdBgBIAMoCzIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Lk1pc3Npb25DdXN0b21WYWx1ZVNuYXBzaG90QhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { MissionCustomValueSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionCustomValueSnapshotList), MissionCustomValueSnapshotList.Parser, new string[1] { "CustomValueList" }, null, null, null, null)
		}));
	}
}
