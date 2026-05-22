using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DrinkMakerCheersMakeDrinkCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DrinkMakerCheersMakeDrinkCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiREcmlua01ha2VyQ2hlZXJzTWFrZURyaW5rQ3NSZXEucHJvdG8aEUNJR0tC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RElHR09JLnByb3RvIn8KHkRyaW5rTWFrZXJDaGVlcnNNYWtlRHJpbmtDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "cRITCgtGTk5NRUxFRUFCSRgFIAEoCBIhCgtJSERNTEhGQUVLSBgHIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "LkNJR0tCRElHR09JEhAKCGdyb3VwX2lkGA0gASgNEhMKC05NS0pCS0NFSUdQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { CIGKBDIGGOIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DrinkMakerCheersMakeDrinkCsReq), DrinkMakerCheersMakeDrinkCsReq.Parser, new string[4] { "FNNMELEEABI", "IHDMLHFAEKH", "GroupId", "NMKJBKCEIGP" }, null, null, null, null)
		}));
	}
}
