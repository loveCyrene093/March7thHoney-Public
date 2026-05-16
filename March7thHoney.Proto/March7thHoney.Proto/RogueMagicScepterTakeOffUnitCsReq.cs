using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicScepterTakeOffUnitCsReq : IMessage<RogueMagicScepterTakeOffUnitCsReq>, IMessage, IEquatable<RogueMagicScepterTakeOffUnitCsReq>, IDeepCloneable<RogueMagicScepterTakeOffUnitCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicScepterTakeOffUnitCsReq> _parser = new MessageParser<RogueMagicScepterTakeOffUnitCsReq>(() => new RogueMagicScepterTakeOffUnitCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DOAOPBBIGPOFieldNumber = 7;

	private uint dOAOPBBIGPO_;

	public const int IGEABMFLCGCFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_iGEABMFLCGC_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> iGEABMFLCGC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicScepterTakeOffUnitCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicScepterTakeOffUnitCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOAOPBBIGPO
	{
		get
		{
			return dOAOPBBIGPO_;
		}
		set
		{
			dOAOPBBIGPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IGEABMFLCGC => iGEABMFLCGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicScepterTakeOffUnitCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicScepterTakeOffUnitCsReq(RogueMagicScepterTakeOffUnitCsReq other)
		: this()
	{
		dOAOPBBIGPO_ = other.dOAOPBBIGPO_;
		iGEABMFLCGC_ = other.iGEABMFLCGC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicScepterTakeOffUnitCsReq Clone()
	{
		return new RogueMagicScepterTakeOffUnitCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicScepterTakeOffUnitCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicScepterTakeOffUnitCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DOAOPBBIGPO != other.DOAOPBBIGPO)
		{
			return false;
		}
		if (!iGEABMFLCGC_.Equals(other.iGEABMFLCGC_))
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
		if (DOAOPBBIGPO != 0)
		{
			num ^= DOAOPBBIGPO.GetHashCode();
		}
		num ^= iGEABMFLCGC_.GetHashCode();
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
		if (DOAOPBBIGPO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DOAOPBBIGPO);
		}
		iGEABMFLCGC_.WriteTo(ref output, _repeated_iGEABMFLCGC_codec);
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
		if (DOAOPBBIGPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOAOPBBIGPO);
		}
		num += iGEABMFLCGC_.CalculateSize(_repeated_iGEABMFLCGC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicScepterTakeOffUnitCsReq other)
	{
		if (other != null)
		{
			if (other.DOAOPBBIGPO != 0)
			{
				DOAOPBBIGPO = other.DOAOPBBIGPO;
			}
			iGEABMFLCGC_.Add(other.iGEABMFLCGC_);
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
				DOAOPBBIGPO = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				iGEABMFLCGC_.AddEntriesFrom(ref input, _repeated_iGEABMFLCGC_codec);
				break;
			}
		}
	}
}
