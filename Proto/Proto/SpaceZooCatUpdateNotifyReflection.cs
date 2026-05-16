using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooCatUpdateNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooCatUpdateNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1TcGFjZVpvb0NhdFVwZGF0ZU5vdGlmeS5wcm90bxoRTEtKTUxQSkVQR0cu";
		buffer[1] = "cHJvdG8iZgoXU3BhY2Vab29DYXRVcGRhdGVOb3RpZnkSEwoLRExBS0VMT0VP";
		buffer[2] = "T0MYBCABKAgSEwoLQkZBTExDR0lQT0cYCCABKAgSIQoLRERMSFBEQkhHSkQY";
		buffer[3] = "DCADKAsyDC5MS0pNTFBKRVBHR0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { LKJMLPJEPGGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooCatUpdateNotify), SpaceZooCatUpdateNotify.Parser, new string[3] { "DLAKELOEOOC", "BFALLCGIPOG", "DDLHPDBHGJD" }, null, null, null, null)
		}));
	}
}
