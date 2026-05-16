using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdLobbyTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdLobbyTypeReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 0) = "ChJDbWRMb2JieVR5cGUucHJvdG8q2wQKDENtZExvYmJ5VHlwZRIbChdMQURN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 1) = "TExQSUFCRV9QQ1BESEVMUEtFTRAAEhYKEUNtZExvYmJ5Sm9pblNjUnNwENE5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 2) = "EhMKDkNtZE9IQ0pCREdMUE1LENk5Eh0KGENtZExvYmJ5U3luY0luZm9TY05v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 3) = "dGlmeRC4ORIdChhDbWRMb2JieUludGVyYWN0U2NOb3RpZnkQ5zkSEwoOQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 4) = "T0dHQkVOSUpLT0YQ3DkSEwoOQ21kRlBERlBDRENLSEIQxTkSEwoOQ21kRkxO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 5) = "S0hFTUJKT0cQyTkSEwoOQ21kTU5IQ0xLSExBSE0QyDkSEwoOQ21kSURMQ0RC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 6) = "TlBDQkcQ2jkSEwoOQ21kQkdLSUVGQ0xHREYQuTkSGQoUQ21kTG9iYnlHZXRJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 7) = "bmZvU2NSc3AQxjkSGAoTQ21kTG9iYnlDcmVhdGVTY1JzcBC9ORIZChRDbWRM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 8) = "b2JieUtpY2tPdXRDc1JlcRDlORIZChRDbWRMb2JieUdldEluZm9Dc1JlcRDo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 9) = "ORIYChNDbWRMb2JieUludml0ZUNzUmVxEOI5EhMKDkNtZFBMTU1ETkNKSEJH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 10) = "ELc5EiIKHUNtZExvYmJ5TW9kaWZ5UGxheWVySW5mb0NzUmVxELs5EhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 11) = "ZFBJSkZNRU1ERERGELw5EhYKEUNtZExvYmJ5Sm9pbkNzUmVxENQ5EhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 12) = "ZENLTUlHRUlBQ0lPEMs5EhgKE0NtZExvYmJ5Q3JlYXRlQ3NSZXEQwzkSFgoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 13) = "Q21kTG9iYnlRdWl0Q3NSZXEQ4zkSEwoOQ21kSEtGRENCT09FSU8Q1TlCFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 14) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray15<string>, string>(in buffer, 15))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdLobbyType) }, null, null));
	}
}
