using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BNDOCFACDLL : IMessage<BNDOCFACDLL>, IMessage, IEquatable<BNDOCFACDLL>, IDeepCloneable<BNDOCFACDLL>, IBufferMessage
{
	private static readonly MessageParser<BNDOCFACDLL> _parser = new MessageParser<BNDOCFACDLL>(() => new BNDOCFACDLL());

	private UnknownFieldSet _unknownFields;

	public const int ComposeRelicIdFieldNumber = 1;

	private uint composeRelicId_;

	public const int RelicTypeFieldNumber = 2;

	private uint relicType_;

	public const int JKNGFDMOCGCFieldNumber = 3;

	private BPDFEOGCAIJ jKNGFDMOCGC_;

	public const int SubAffixListFieldNumber = 4;

	private static readonly FieldCodec<BPDFEOGCAIJ> _repeated_subAffixList_codec = FieldCodec.ForMessage(34u, BPDFEOGCAIJ.Parser);

	private readonly RepeatedField<BPDFEOGCAIJ> subAffixList_ = new RepeatedField<BPDFEOGCAIJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BNDOCFACDLL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BNDOCFACDLLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ComposeRelicId
	{
		get
		{
			return composeRelicId_;
		}
		set
		{
			composeRelicId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RelicType
	{
		get
		{
			return relicType_;
		}
		set
		{
			relicType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPDFEOGCAIJ JKNGFDMOCGC
	{
		get
		{
			return jKNGFDMOCGC_;
		}
		set
		{
			jKNGFDMOCGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BPDFEOGCAIJ> SubAffixList => subAffixList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNDOCFACDLL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNDOCFACDLL(BNDOCFACDLL other)
		: this()
	{
		composeRelicId_ = other.composeRelicId_;
		relicType_ = other.relicType_;
		jKNGFDMOCGC_ = ((other.jKNGFDMOCGC_ != null) ? other.jKNGFDMOCGC_.Clone() : null);
		subAffixList_ = other.subAffixList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNDOCFACDLL Clone()
	{
		return new BNDOCFACDLL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BNDOCFACDLL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BNDOCFACDLL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ComposeRelicId != other.ComposeRelicId)
		{
			return false;
		}
		if (RelicType != other.RelicType)
		{
			return false;
		}
		if (!object.Equals(JKNGFDMOCGC, other.JKNGFDMOCGC))
		{
			return false;
		}
		if (!subAffixList_.Equals(other.subAffixList_))
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
		if (ComposeRelicId != 0)
		{
			num ^= ComposeRelicId.GetHashCode();
		}
		if (RelicType != 0)
		{
			num ^= RelicType.GetHashCode();
		}
		if (jKNGFDMOCGC_ != null)
		{
			num ^= JKNGFDMOCGC.GetHashCode();
		}
		num ^= subAffixList_.GetHashCode();
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
		if (ComposeRelicId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ComposeRelicId);
		}
		if (RelicType != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(RelicType);
		}
		if (jKNGFDMOCGC_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(JKNGFDMOCGC);
		}
		subAffixList_.WriteTo(ref output, _repeated_subAffixList_codec);
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
		if (ComposeRelicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ComposeRelicId);
		}
		if (RelicType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RelicType);
		}
		if (jKNGFDMOCGC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JKNGFDMOCGC);
		}
		num += subAffixList_.CalculateSize(_repeated_subAffixList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BNDOCFACDLL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ComposeRelicId != 0)
		{
			ComposeRelicId = other.ComposeRelicId;
		}
		if (other.RelicType != 0)
		{
			RelicType = other.RelicType;
		}
		if (other.jKNGFDMOCGC_ != null)
		{
			if (jKNGFDMOCGC_ == null)
			{
				JKNGFDMOCGC = new BPDFEOGCAIJ();
			}
			JKNGFDMOCGC.MergeFrom(other.JKNGFDMOCGC);
		}
		subAffixList_.Add(other.subAffixList_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				ComposeRelicId = input.ReadUInt32();
				break;
			case 16u:
				RelicType = input.ReadUInt32();
				break;
			case 26u:
				if (jKNGFDMOCGC_ == null)
				{
					JKNGFDMOCGC = new BPDFEOGCAIJ();
				}
				input.ReadMessage(JKNGFDMOCGC);
				break;
			case 34u:
				subAffixList_.AddEntriesFrom(ref input, _repeated_subAffixList_codec);
				break;
			}
		}
	}
}
