using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameTraitPb : IMessage<GridFightGameTraitPb>, IMessage, IEquatable<GridFightGameTraitPb>, IDeepCloneable<GridFightGameTraitPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameTraitPb> _parser = new MessageParser<GridFightGameTraitPb>(() => new GridFightGameTraitPb());

	private UnknownFieldSet _unknownFields;

	public const int TraitIdFieldNumber = 1;

	private uint traitId_;

	public const int EffectsFieldNumber = 2;

	private static readonly FieldCodec<GridFightGameTraitEffectPb> _repeated_effects_codec = FieldCodec.ForMessage(18u, GridFightGameTraitEffectPb.Parser);

	private readonly RepeatedField<GridFightGameTraitEffectPb> effects_ = new RepeatedField<GridFightGameTraitEffectPb>();

	public const int TraitLayerFieldNumber = 3;

	private uint traitLayer_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameTraitPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[17];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<GridFightGameTraitEffectPb> Effects => effects_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitLayer
	{
		get
		{
			return traitLayer_;
		}
		set
		{
			traitLayer_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitPb(GridFightGameTraitPb other)
		: this()
	{
		traitId_ = other.traitId_;
		effects_ = other.effects_.Clone();
		traitLayer_ = other.traitLayer_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitPb Clone()
	{
		return new GridFightGameTraitPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameTraitPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameTraitPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (!effects_.Equals(other.effects_))
		{
			return false;
		}
		if (TraitLayer != other.TraitLayer)
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
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		num ^= effects_.GetHashCode();
		if (TraitLayer != 0)
		{
			num ^= TraitLayer.GetHashCode();
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
		if (TraitId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TraitId);
		}
		effects_.WriteTo(ref output, _repeated_effects_codec);
		if (TraitLayer != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(TraitLayer);
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
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		num += effects_.CalculateSize(_repeated_effects_codec);
		if (TraitLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitLayer);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameTraitPb other)
	{
		if (other != null)
		{
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
			}
			effects_.Add(other.effects_);
			if (other.TraitLayer != 0)
			{
				TraitLayer = other.TraitLayer;
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				TraitId = input.ReadUInt32();
				break;
			case 18u:
				effects_.AddEntriesFrom(ref input, _repeated_effects_codec);
				break;
			case 24u:
				TraitLayer = input.ReadUInt32();
				break;
			}
		}
	}
}
