using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGetRegionProgressScRsp : IMessage<MonopolyGetRegionProgressScRsp>, IMessage, IEquatable<MonopolyGetRegionProgressScRsp>, IDeepCloneable<MonopolyGetRegionProgressScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGetRegionProgressScRsp> _parser = new MessageParser<MonopolyGetRegionProgressScRsp>(() => new MonopolyGetRegionProgressScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int EKIMLIAMFHEFieldNumber = 10;

	private uint eKIMLIAMFHE_;

	public const int FKAKCCJCGAFFieldNumber = 12;

	private uint fKAKCCJCGAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGetRegionProgressScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGetRegionProgressScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EKIMLIAMFHE
	{
		get
		{
			return eKIMLIAMFHE_;
		}
		set
		{
			eKIMLIAMFHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKAKCCJCGAF
	{
		get
		{
			return fKAKCCJCGAF_;
		}
		set
		{
			fKAKCCJCGAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRegionProgressScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRegionProgressScRsp(MonopolyGetRegionProgressScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		eKIMLIAMFHE_ = other.eKIMLIAMFHE_;
		fKAKCCJCGAF_ = other.fKAKCCJCGAF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRegionProgressScRsp Clone()
	{
		return new MonopolyGetRegionProgressScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGetRegionProgressScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGetRegionProgressScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EKIMLIAMFHE != other.EKIMLIAMFHE)
		{
			return false;
		}
		if (FKAKCCJCGAF != other.FKAKCCJCGAF)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EKIMLIAMFHE != 0)
		{
			num ^= EKIMLIAMFHE.GetHashCode();
		}
		if (FKAKCCJCGAF != 0)
		{
			num ^= FKAKCCJCGAF.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (EKIMLIAMFHE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EKIMLIAMFHE);
		}
		if (FKAKCCJCGAF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(FKAKCCJCGAF);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EKIMLIAMFHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EKIMLIAMFHE);
		}
		if (FKAKCCJCGAF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKAKCCJCGAF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyGetRegionProgressScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EKIMLIAMFHE != 0)
			{
				EKIMLIAMFHE = other.EKIMLIAMFHE;
			}
			if (other.FKAKCCJCGAF != 0)
			{
				FKAKCCJCGAF = other.FKAKCCJCGAF;
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
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 80u:
				EKIMLIAMFHE = input.ReadUInt32();
				break;
			case 96u:
				FKAKCCJCGAF = input.ReadUInt32();
				break;
			}
		}
	}
}
