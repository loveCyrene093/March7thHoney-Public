using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DiscardRelicCsReq : IMessage<DiscardRelicCsReq>, IMessage, IEquatable<DiscardRelicCsReq>, IDeepCloneable<DiscardRelicCsReq>, IBufferMessage
{
	private static readonly MessageParser<DiscardRelicCsReq> _parser = new MessageParser<DiscardRelicCsReq>(() => new DiscardRelicCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MHMFIIPEMJDFieldNumber = 2;

	private ulong mHMFIIPEMJD_;

	public const int DiscardedFieldNumber = 6;

	private bool discarded_;

	public const int RelicIdsFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_relicIds_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> relicIds_ = new RepeatedField<uint>();

	public const int HHHLMNLMAGCFieldNumber = 11;

	private RelicDiscardType hHHLMNLMAGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DiscardRelicCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DiscardRelicCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong MHMFIIPEMJD
	{
		get
		{
			return mHMFIIPEMJD_;
		}
		set
		{
			mHMFIIPEMJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Discarded
	{
		get
		{
			return discarded_;
		}
		set
		{
			discarded_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> RelicIds => relicIds_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicDiscardType HHHLMNLMAGC
	{
		get
		{
			return hHHLMNLMAGC_;
		}
		set
		{
			hHHLMNLMAGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiscardRelicCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiscardRelicCsReq(DiscardRelicCsReq other)
		: this()
	{
		mHMFIIPEMJD_ = other.mHMFIIPEMJD_;
		discarded_ = other.discarded_;
		relicIds_ = other.relicIds_.Clone();
		hHHLMNLMAGC_ = other.hHHLMNLMAGC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiscardRelicCsReq Clone()
	{
		return new DiscardRelicCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DiscardRelicCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DiscardRelicCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MHMFIIPEMJD != other.MHMFIIPEMJD)
		{
			return false;
		}
		if (Discarded != other.Discarded)
		{
			return false;
		}
		if (!relicIds_.Equals(other.relicIds_))
		{
			return false;
		}
		if (HHHLMNLMAGC != other.HHHLMNLMAGC)
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
		if (MHMFIIPEMJD != 0L)
		{
			num ^= MHMFIIPEMJD.GetHashCode();
		}
		if (Discarded)
		{
			num ^= Discarded.GetHashCode();
		}
		num ^= relicIds_.GetHashCode();
		if (HHHLMNLMAGC != RelicDiscardType.EgejgnadohgIfpdlcoienf)
		{
			num ^= HHHLMNLMAGC.GetHashCode();
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
		if (MHMFIIPEMJD != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(MHMFIIPEMJD);
		}
		if (Discarded)
		{
			output.WriteRawTag(48);
			output.WriteBool(Discarded);
		}
		relicIds_.WriteTo(ref output, _repeated_relicIds_codec);
		if (HHHLMNLMAGC != RelicDiscardType.EgejgnadohgIfpdlcoienf)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)HHHLMNLMAGC);
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
		if (MHMFIIPEMJD != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MHMFIIPEMJD);
		}
		if (Discarded)
		{
			num += 2;
		}
		num += relicIds_.CalculateSize(_repeated_relicIds_codec);
		if (HHHLMNLMAGC != RelicDiscardType.EgejgnadohgIfpdlcoienf)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HHHLMNLMAGC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DiscardRelicCsReq other)
	{
		if (other != null)
		{
			if (other.MHMFIIPEMJD != 0L)
			{
				MHMFIIPEMJD = other.MHMFIIPEMJD;
			}
			if (other.Discarded)
			{
				Discarded = other.Discarded;
			}
			relicIds_.Add(other.relicIds_);
			if (other.HHHLMNLMAGC != RelicDiscardType.EgejgnadohgIfpdlcoienf)
			{
				HHHLMNLMAGC = other.HHHLMNLMAGC;
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
			case 16u:
				MHMFIIPEMJD = input.ReadUInt64();
				break;
			case 48u:
				Discarded = input.ReadBool();
				break;
			case 56u:
			case 58u:
				relicIds_.AddEntriesFrom(ref input, _repeated_relicIds_codec);
				break;
			case 88u:
				HHHLMNLMAGC = (RelicDiscardType)input.ReadEnum();
				break;
			}
		}
	}
}
