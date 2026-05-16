using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BJOBDLDHOCC : IMessage<BJOBDLDHOCC>, IMessage, IEquatable<BJOBDLDHOCC>, IDeepCloneable<BJOBDLDHOCC>, IBufferMessage
{
	private static readonly MessageParser<BJOBDLDHOCC> _parser = new MessageParser<BJOBDLDHOCC>(() => new BJOBDLDHOCC());

	private UnknownFieldSet _unknownFields;

	public const int PANFIPHAGPBFieldNumber = 1;

	private uint pANFIPHAGPB_;

	public const int IAMCPKMNANOFieldNumber = 2;

	private uint iAMCPKMNANO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BJOBDLDHOCC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BJOBDLDHOCCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PANFIPHAGPB
	{
		get
		{
			return pANFIPHAGPB_;
		}
		set
		{
			pANFIPHAGPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IAMCPKMNANO
	{
		get
		{
			return iAMCPKMNANO_;
		}
		set
		{
			iAMCPKMNANO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOBDLDHOCC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOBDLDHOCC(BJOBDLDHOCC other)
		: this()
	{
		pANFIPHAGPB_ = other.pANFIPHAGPB_;
		iAMCPKMNANO_ = other.iAMCPKMNANO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOBDLDHOCC Clone()
	{
		return new BJOBDLDHOCC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BJOBDLDHOCC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BJOBDLDHOCC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PANFIPHAGPB != other.PANFIPHAGPB)
		{
			return false;
		}
		if (IAMCPKMNANO != other.IAMCPKMNANO)
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
		if (PANFIPHAGPB != 0)
		{
			num ^= PANFIPHAGPB.GetHashCode();
		}
		if (IAMCPKMNANO != 0)
		{
			num ^= IAMCPKMNANO.GetHashCode();
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
		if (PANFIPHAGPB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PANFIPHAGPB);
		}
		if (IAMCPKMNANO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IAMCPKMNANO);
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
		if (PANFIPHAGPB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PANFIPHAGPB);
		}
		if (IAMCPKMNANO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAMCPKMNANO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BJOBDLDHOCC other)
	{
		if (other != null)
		{
			if (other.PANFIPHAGPB != 0)
			{
				PANFIPHAGPB = other.PANFIPHAGPB;
			}
			if (other.IAMCPKMNANO != 0)
			{
				IAMCPKMNANO = other.IAMCPKMNANO;
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
				PANFIPHAGPB = input.ReadUInt32();
				break;
			case 16u:
				IAMCPKMNANO = input.ReadUInt32();
				break;
			}
		}
	}
}
