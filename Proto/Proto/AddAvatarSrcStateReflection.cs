using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddAvatarSrcStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddAvatarSrcStateReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdBZGRBdmF0YXJTcmNTdGF0ZS5wcm90byp9ChFBZGRBdmF0YXJTcmNTdGF0";
		buffer[1] = "ZRIXChNBRERfQVZBVEFSX1NSQ19OT05FEAASGAoUQUREX0FWQVRBUl9TUkNf";
		buffer[2] = "R0FDSEEQARIYChRBRERfQVZBVEFSX1NSQ19ST0dVRRACEhsKF0FERF9BVkFU";
		buffer[3] = "QVJfU1JDX0RFTElWRVJZEANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AddAvatarSrcState) }, null, null));
	}
}
