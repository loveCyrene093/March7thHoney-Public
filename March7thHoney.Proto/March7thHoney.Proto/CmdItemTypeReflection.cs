using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdItemTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdItemTypeReflection()
	{
		_003C_003Ey__InlineArray40<string> buffer = default(_003C_003Ey__InlineArray40<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 0) = "ChFDbWRJdGVtVHlwZS5wcm90byrHDQoLQ21kSXRlbVR5cGUSGwoXRlBQUElB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 1) = "TEdHS0xfUENQREhFTFBLRU0QABIeChlDbWRTZXRUdXJuRm9vZFN3aXRjaENz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 2) = "UmVxEIgEEh8KGkNtZFNwZWNpYWxDb21wb3NlSXRlbUNzUmVxEL4EEhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 3) = "ZEtGREdORkJBT0dOEJEEEh0KGENtZENtZExvY2tFcXVpcG1lbnRDc1JlcRCC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 4) = "BBIgChtDbWRNYXJrUmVsaWNGaWx0ZXJQbGFuU2NSc3AQwQQSFwoSQ21kRXhw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 5) = "VXBSZWxpY1NjUnNwEJoEEhkKFENtZFJlbGljUmVmb3JnZUNzUmVxEPoDEhgK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 6) = "E0NtZERlc3Ryb3lJdGVtU2NSc3AQqQQSEwoOQ21kR2V0QmFnQ3NSZXEQzwQS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 7) = "EwoOQ21kR2V0QmFnU2NSc3AQ/gMSGwoWQ21kRXhwVXBFcXVpcG1lbnRDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 8) = "cRCbBBIVChBDbWRNYXJrSXRlbVNjUnNwEI0EEiUKIENtZENvbXBvc2VMaW1p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 9) = "dE51bVVwZGF0ZVNjTm90aWZ5ELUEEhMKDkNtZElMSkpCR05FTUhIEM4EEh8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 10) = "GkNtZEdldFJlbGljRmlsdGVyUGxhbkNzUmVxEJgEEhMKDkNtZEhLSkdESUtK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 11) = "SUdJEMwEEhwKF0NtZFJhbmtVcEVxdWlwbWVudENzUmVxELMEEhUKEENtZE1h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 12) = "cmtJdGVtQ3NSZXEQpwQSGwoWQ21kR2V0UmVjeWNsZVRpbWVDc1JlcRCtBBIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 13) = "Cg5DbWRBRENFQUNJTUtMRxDRBBIUCg9DbWRVc2VJdGVtQ3NSZXEQ/QMSHAoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 14) = "Q21kR2V0TWFya0l0ZW1MaXN0U2NSc3AQhQQSGwoWQ21kRXhwVXBFcXVpcG1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 15) = "bnRTY1JzcBD1AxIfChpDbWRBZGRSZWxpY0ZpbHRlclBsYW5TY1JzcBCMBBIZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 16) = "ChRDbWRBZGRFcXVpcG1lbnRTY1JzcBDUBBIhChxDbWRCYXRjaFJhbmtVcEVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 17) = "dWlwbWVudENzUmVxELkEEhUKEENtZFNlbGxJdGVtU2NSc3AQsQQSJwoiQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 18) = "Q29tcG9zZUxpbWl0TnVtQ29tcGxldGVTY05vdGlmeRCQBBIhChxDbWRDb21w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 19) = "b3NlU2VsZWN0ZWRSZWxpY0NzUmVxENgEEhoKFUNtZFJlY2hhcmdlU3VjY05v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 20) = "dGlmeRD7AxIiCh1DbWRNb2RpZnlSZWxpY0ZpbHRlclBsYW5Dc1JlcRDCBBIf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 21) = "ChpDbWRBZGRSZWxpY0ZpbHRlclBsYW5Dc1JlcRDQBBITCg5DbWRPUEROTUxL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 22) = "TU5CQhCOBBITCg5DbWRBQ09OSUZKSktDRxCEBBIYChNDbWRDbWRTZWxsSXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 23) = "bUNzUmVxEJUEEiIKHUNtZERlbGV0ZVJlbGljRmlsdGVyUGxhbkNzUmVxEK8E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 24) = "EhkKFENtZENtZExvY2tSZWxpY0NzUmVxELwEEhMKDkNtZEdIQ0lPR01IT1BQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 25) = "EJ0EEh8KGkNtZEdldFJlbGljRmlsdGVyUGxhblNjUnNwEPcDEhgKE0NtZENv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 26) = "bXBvc2VJdGVtU2NSc3AQmQQSEwoOQ21kRE1KTkFHRUtPTkEQ0wQSGAoTQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 27) = "RGVzdHJveUl0ZW1Dc1JlcRC9BBIZChRDbWREaXNjYXJkUmVsaWNTY1JzcBC2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 28) = "BBIXChJDbWRFeHBVcFJlbGljQ3NSZXEQ+AMSGgoVQ21kR2V0UmVjeWxlVGlt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 29) = "ZVNjUnNwEIkEEiAKG0NtZFJlbGljUmVmb3JnZUNvbmZpcm1Dc1JlcRCoBBIi";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 30) = "Ch1DbWRNb2RpZnlSZWxpY0ZpbHRlclBsYW5TY1JzcBCeBBIcChdDbWRDYW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 31) = "ZWxNYXJrSXRlbU5vdGlmeRCqBBIUCg9DbWRVc2VJdGVtU2NSc3AQ1gQSEwoO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 32) = "Q21kTkxERExHREVCTU8QhgQSHQoYQ21kUHJvbW90ZUVxdWlwbWVudENzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 33) = "ENIEEiEKHENtZENvbXBvc2VTZWxlY3RlZFJlbGljU2NSc3AQzQQSEwoOQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 34) = "RUJEREpPQkdESEQQlAQSGgoVQ21kRXhjaGFuZ2VIY29pbkNzUmVxEK4EEiAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 35) = "G0NtZE1hcmtSZWxpY0ZpbHRlclBsYW5Dc1JlcRCABBIaChVDbWRFeGNoYW5n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 36) = "ZUhjb2luU2NSc3AQoAQSJAofQ21kR2VuZXJhbFZpcnR1YWxJdGVtRGF0YU5v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 37) = "dGlmeRD2AxIaChVDbWRTeW5jVHVybkZvb2ROb3RpZnkQwwQSGQoUQ21kRGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 38) = "Y2FyZFJlbGljQ3NSZXEQpQQSHAoXQ21kR2V0TWFya0l0ZW1MaXN0Q3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray40<string>, string>(ref buffer, 39) = "/ANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray40<string>, string>(in buffer, 40))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdItemType) }, null, null));
	}
}
