using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameAugmentPb : IMessage<GridFightGameAugmentPb>, IMessage, IEquatable<GridFightGameAugmentPb>, IDeepCloneable<GridFightGameAugmentPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameAugmentPb> _parser = new MessageParser<GridFightGameAugmentPb>(() => new GridFightGameAugmentPb());

	private UnknownFieldSet _unknownFields;

	public const int AugmentIdFieldNumber = 1;

	private uint augmentId_;

	public const int SavedValuesFieldNumber = 2;

	private static readonly MapField<string, uint>.Codec _map_savedValues_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 18u);

	private readonly MapField<string, uint> savedValues_ = new MapField<string, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameAugmentPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[14];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AugmentId
	{
		get
		{
			return augmentId_;
		}
		set
		{
			augmentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> SavedValues => savedValues_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentPb(GridFightGameAugmentPb other)
		: this()
	{
		augmentId_ = other.augmentId_;
		savedValues_ = other.savedValues_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentPb Clone()
	{
		return new GridFightGameAugmentPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameAugmentPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameAugmentPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AugmentId != other.AugmentId)
		{
			return false;
		}
		if (!SavedValues.Equals(other.SavedValues))
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
		if (AugmentId != 0)
		{
			num ^= AugmentId.GetHashCode();
		}
		num ^= SavedValues.GetHashCode();
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
		if (AugmentId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AugmentId);
		}
		savedValues_.WriteTo(ref output, _map_savedValues_codec);
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
		if (AugmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AugmentId);
		}
		num += savedValues_.CalculateSize(_map_savedValues_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameAugmentPb other)
	{
		if (other != null)
		{
			if (other.AugmentId != 0)
			{
				AugmentId = other.AugmentId;
			}
			savedValues_.MergeFrom(other.savedValues_);
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
				AugmentId = input.ReadUInt32();
				break;
			case 18u:
				savedValues_.AddEntriesFrom(ref input, _map_savedValues_codec);
				break;
			}
		}
	}
}
