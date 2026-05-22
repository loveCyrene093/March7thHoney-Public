using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NHJCELBCFNF : IMessage<NHJCELBCFNF>, IMessage, IEquatable<NHJCELBCFNF>, IDeepCloneable<NHJCELBCFNF>, IBufferMessage
{
	private static readonly MessageParser<NHJCELBCFNF> _parser = new MessageParser<NHJCELBCFNF>(() => new NHJCELBCFNF());

	private UnknownFieldSet _unknownFields;

	public const int BJKNLGIBCGBFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_bJKNLGIBCGB_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> bJKNLGIBCGB_ = new RepeatedField<uint>();

	public const int EffectIdFieldNumber = 9;

	private uint effectId_;

	public const int TraitIdFieldNumber = 13;

	private uint traitId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NHJCELBCFNF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NHJCELBCFNFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BJKNLGIBCGB => bJKNLGIBCGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EffectId
	{
		get
		{
			return effectId_;
		}
		set
		{
			effectId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHJCELBCFNF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHJCELBCFNF(NHJCELBCFNF other)
		: this()
	{
		bJKNLGIBCGB_ = other.bJKNLGIBCGB_.Clone();
		effectId_ = other.effectId_;
		traitId_ = other.traitId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHJCELBCFNF Clone()
	{
		return new NHJCELBCFNF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NHJCELBCFNF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NHJCELBCFNF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bJKNLGIBCGB_.Equals(other.bJKNLGIBCGB_))
		{
			return false;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		if (TraitId != other.TraitId)
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
		num ^= bJKNLGIBCGB_.GetHashCode();
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
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
		bJKNLGIBCGB_.WriteTo(ref output, _repeated_bJKNLGIBCGB_codec);
		if (EffectId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EffectId);
		}
		if (TraitId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(TraitId);
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
		num += bJKNLGIBCGB_.CalculateSize(_repeated_bJKNLGIBCGB_codec);
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectId);
		}
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NHJCELBCFNF other)
	{
		if (other != null)
		{
			bJKNLGIBCGB_.Add(other.bJKNLGIBCGB_);
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
			}
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
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
			case 64u:
			case 66u:
				bJKNLGIBCGB_.AddEntriesFrom(ref input, _repeated_bJKNLGIBCGB_codec);
				break;
			case 72u:
				EffectId = input.ReadUInt32();
				break;
			case 104u:
				TraitId = input.ReadUInt32();
				break;
			}
		}
	}
}
