using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantPlantSeedCsReq : IMessage<ElfRestaurantPlantSeedCsReq>, IMessage, IEquatable<ElfRestaurantPlantSeedCsReq>, IDeepCloneable<ElfRestaurantPlantSeedCsReq>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantPlantSeedCsReq> _parser = new MessageParser<ElfRestaurantPlantSeedCsReq>(() => new ElfRestaurantPlantSeedCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FOPHPJNGPDEFieldNumber = 1;

	private static readonly FieldCodec<BHHNMHDDIDD> _repeated_fOPHPJNGPDE_codec = FieldCodec.ForMessage(10u, BHHNMHDDIDD.Parser);

	private readonly RepeatedField<BHHNMHDDIDD> fOPHPJNGPDE_ = new RepeatedField<BHHNMHDDIDD>();

	public const int IALJOJMAFLLFieldNumber = 10;

	private uint iALJOJMAFLL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantPlantSeedCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantPlantSeedCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BHHNMHDDIDD> FOPHPJNGPDE => fOPHPJNGPDE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IALJOJMAFLL
	{
		get
		{
			return iALJOJMAFLL_;
		}
		set
		{
			iALJOJMAFLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantPlantSeedCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantPlantSeedCsReq(ElfRestaurantPlantSeedCsReq other)
		: this()
	{
		fOPHPJNGPDE_ = other.fOPHPJNGPDE_.Clone();
		iALJOJMAFLL_ = other.iALJOJMAFLL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantPlantSeedCsReq Clone()
	{
		return new ElfRestaurantPlantSeedCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantPlantSeedCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantPlantSeedCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fOPHPJNGPDE_.Equals(other.fOPHPJNGPDE_))
		{
			return false;
		}
		if (IALJOJMAFLL != other.IALJOJMAFLL)
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
		num ^= fOPHPJNGPDE_.GetHashCode();
		if (IALJOJMAFLL != 0)
		{
			num ^= IALJOJMAFLL.GetHashCode();
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
		fOPHPJNGPDE_.WriteTo(ref output, _repeated_fOPHPJNGPDE_codec);
		if (IALJOJMAFLL != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IALJOJMAFLL);
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
		num += fOPHPJNGPDE_.CalculateSize(_repeated_fOPHPJNGPDE_codec);
		if (IALJOJMAFLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IALJOJMAFLL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantPlantSeedCsReq other)
	{
		if (other != null)
		{
			fOPHPJNGPDE_.Add(other.fOPHPJNGPDE_);
			if (other.IALJOJMAFLL != 0)
			{
				IALJOJMAFLL = other.IALJOJMAFLL;
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
			case 10u:
				fOPHPJNGPDE_.AddEntriesFrom(ref input, _repeated_fOPHPJNGPDE_codec);
				break;
			case 80u:
				IALJOJMAFLL = input.ReadUInt32();
				break;
			}
		}
	}
}
