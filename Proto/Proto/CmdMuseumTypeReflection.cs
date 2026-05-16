using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMuseumTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMuseumTypeReflection()
	{
		_003C_003Ey__InlineArray24<string> buffer = default(_003C_003Ey__InlineArray24<string>);
		buffer[0] = "ChNDbWRNdXNldW1UeXBlLnByb3RvKtgHCg1DbWRNdXNldW1UeXBlEhsKF09E";
		buffer[1] = "T09ER0hBSUpOX1BDUERIRUxQS0VNEAASGwoWQ21kU2V0U3R1ZmZUb0FyZWFD";
		buffer[2] = "c1JlcRDaIRIcChdDbWRVcGdyYWRlQXJlYVN0YXRDc1JlcRDQIRITCg5DbWRJ";
		buffer[3] = "QkZDSkJDS0VOSRCwIhIaChVDbWRGaW5pc2hDdXJUdXJuQ3NSZXEQ8yESJAof";
		buffer[4] = "Q21kTXVzZXVtUmFuZG9tRXZlbnRTZWxlY3RDc1JlcRCGIhIjCh5DbWRTeW5j";
		buffer[5] = "TXVzZXVtVGFyZ2V0U3RhcnROb3RpZnkQpSISGwoWQ21kU2V0U3R1ZmZUb0Fy";
		buffer[6] = "ZWFTY1JzcBDeIRIqCiVDbWRTeW5jTXVzZXVtUmFuZG9tRXZlbnRTdGFydFNj";
		buffer[7] = "Tm90aWZ5EO0hEhwKF0NtZFRha2VDb2xsZWN0UmV3YXJkUnNwEOghEhoKFUNt";
		buffer[8] = "ZEdldE11c2V1bUluZm9Dc1JlcRCnIhIYChNDbWRCdXlOcGNTdHVmZlNjUnNw";
		buffer[9] = "EKsiEh4KGUNtZFRha2VDb2xsZWN0UmV3YXJkQ3NSZXEQ4SESJAofQ21kTXVz";
		buffer[10] = "ZXVtUmFuZG9tRXZlbnRTZWxlY3RTY1JzcBD4IRImCiFDbWRTeW5jTXVzZXVt";
		buffer[11] = "RnVuZHNDaGFuZ2VkU2NOb3RpZnkQ7CESIwoeQ21kTXVzZXVtUmFuZG9tRXZl";
		buffer[12] = "bnRRdWVyeUNzUmVxEIkiEhoKFUNtZEZpbmlzaEN1clR1cm5TY1JzcBDNIRIe";
		buffer[13] = "ChlDbWRTeW5jR2V0RXhoaWJpdFNjTm90aWZ5EOYhEhoKFUNtZEdldE11c2V1";
		buffer[14] = "bUluZm9TY1JzcBDWIRIYChNDbWRVcGdyYWRlQXJlYUNzUmVxEJYiEiQKH0Nt";
		buffer[15] = "ZFN5bmNNdXNldW1UYXJnZXRSZXdhcmROb3RpZnkQhSISGAoTQ21kQnV5TnBj";
		buffer[16] = "U3R1ZmZDc1JlcRCqIhIcChdDbWRVcGdyYWRlQXJlYVN0YXRTY1JzcBDyIRIg";
		buffer[17] = "ChtDbWRSZW1vdmVTdHVmZkZyb21BcmVhU2NSc3AQriISIAobQ21kUmVtb3Zl";
		buffer[18] = "U3R1ZmZGcm9tQXJlYUNzUmVxENUhEiMKHkNtZE11c2V1bVJhbmRvbUV2ZW50";
		buffer[19] = "UXVlcnlTY1JzcBDTIRIlCiBDbWRTeW5jTXVzZXVtSW5mb0NoYW5nZWRTY05v";
		buffer[20] = "dGlmeRCUIhIYChNDbWRVcGdyYWRlQXJlYVNjUnNwEPEhEisKJkNtZFN5bmNN";
		buffer[21] = "dXNldW1UYXJnZXRNaXNzaW9uRmluaXNoTm90aWZ5EKwiEhwKF0NtZFN5bmNH";
		buffer[22] = "ZXRTdHVmZlNjTm90aWZ5EIsiQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[23] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMuseumType) }, null, null));
	}
}
