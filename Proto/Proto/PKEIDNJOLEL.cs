using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PKEIDNJOLEL : IMessage<PKEIDNJOLEL>, IMessage, IEquatable<PKEIDNJOLEL>, IDeepCloneable<PKEIDNJOLEL>, IBufferMessage
{
	private static readonly MessageParser<PKEIDNJOLEL> _parser = new MessageParser<PKEIDNJOLEL>(() => new PKEIDNJOLEL());

	private UnknownFieldSet _unknownFields;

	public const int HBCMPOLIKHGFieldNumber = 1;

	private FHBNDNNKDON hBCMPOLIKHG_;

	public const int StatusFieldNumber = 2;

	private LobbyCharacterStatus status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PKEIDNJOLEL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PKEIDNJOLELReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHBNDNNKDON HBCMPOLIKHG
	{
		get
		{
			return hBCMPOLIKHG_;
		}
		set
		{
			hBCMPOLIKHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyCharacterStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKEIDNJOLEL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKEIDNJOLEL(PKEIDNJOLEL other)
		: this()
	{
		hBCMPOLIKHG_ = other.hBCMPOLIKHG_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKEIDNJOLEL Clone()
	{
		return new PKEIDNJOLEL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PKEIDNJOLEL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PKEIDNJOLEL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HBCMPOLIKHG != other.HBCMPOLIKHG)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (HBCMPOLIKHG != FHBNDNNKDON.Eebjaafcfbf)
		{
			num ^= HBCMPOLIKHG.GetHashCode();
		}
		if (Status != LobbyCharacterStatus.JobbklnganpPcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (HBCMPOLIKHG != FHBNDNNKDON.Eebjaafcfbf)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)HBCMPOLIKHG);
		}
		if (Status != LobbyCharacterStatus.JobbklnganpPcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Status);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (HBCMPOLIKHG != FHBNDNNKDON.Eebjaafcfbf)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HBCMPOLIKHG);
		}
		if (Status != LobbyCharacterStatus.JobbklnganpPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PKEIDNJOLEL other)
	{
		if (other != null)
		{
			if (other.HBCMPOLIKHG != FHBNDNNKDON.Eebjaafcfbf)
			{
				HBCMPOLIKHG = other.HBCMPOLIKHG;
			}
			if (other.Status != LobbyCharacterStatus.JobbklnganpPcpdhelpkem)
			{
				Status = other.Status;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				HBCMPOLIKHG = (FHBNDNNKDON)input.ReadEnum();
				break;
			case 16u:
				Status = (LobbyCharacterStatus)input.ReadEnum();
				break;
			}
		}
	}
}
