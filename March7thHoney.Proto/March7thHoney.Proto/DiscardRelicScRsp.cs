using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DiscardRelicScRsp : IMessage<DiscardRelicScRsp>, IMessage, IEquatable<DiscardRelicScRsp>, IDeepCloneable<DiscardRelicScRsp>, IBufferMessage
{
	private static readonly MessageParser<DiscardRelicScRsp> _parser = new MessageParser<DiscardRelicScRsp>(() => new DiscardRelicScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int RelicIdsFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_relicIds_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> relicIds_ = new RepeatedField<uint>();

	public const int DiscardedFieldNumber = 12;

	private bool discarded_;

	public const int HHHLMNLMAGCFieldNumber = 14;

	private RelicDiscardType hHHLMNLMAGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DiscardRelicScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DiscardRelicScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> RelicIds => relicIds_;

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
	public DiscardRelicScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiscardRelicScRsp(DiscardRelicScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		relicIds_ = other.relicIds_.Clone();
		discarded_ = other.discarded_;
		hHHLMNLMAGC_ = other.hHHLMNLMAGC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiscardRelicScRsp Clone()
	{
		return new DiscardRelicScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DiscardRelicScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DiscardRelicScRsp other)
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
		if (!relicIds_.Equals(other.relicIds_))
		{
			return false;
		}
		if (Discarded != other.Discarded)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= relicIds_.GetHashCode();
		if (Discarded)
		{
			num ^= Discarded.GetHashCode();
		}
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		relicIds_.WriteTo(ref output, _repeated_relicIds_codec);
		if (Discarded)
		{
			output.WriteRawTag(96);
			output.WriteBool(Discarded);
		}
		if (HHHLMNLMAGC != RelicDiscardType.EgejgnadohgIfpdlcoienf)
		{
			output.WriteRawTag(112);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += relicIds_.CalculateSize(_repeated_relicIds_codec);
		if (Discarded)
		{
			num += 2;
		}
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
	public void MergeFrom(DiscardRelicScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			relicIds_.Add(other.relicIds_);
			if (other.Discarded)
			{
				Discarded = other.Discarded;
			}
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
				Retcode = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				relicIds_.AddEntriesFrom(ref input, _repeated_relicIds_codec);
				break;
			case 96u:
				Discarded = input.ReadBool();
				break;
			case 112u:
				HHHLMNLMAGC = (RelicDiscardType)input.ReadEnum();
				break;
			}
		}
	}
}
