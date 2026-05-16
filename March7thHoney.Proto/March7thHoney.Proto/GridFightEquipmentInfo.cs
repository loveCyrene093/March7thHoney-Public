using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightEquipmentInfo : IMessage<GridFightEquipmentInfo>, IMessage, IEquatable<GridFightEquipmentInfo>, IDeepCloneable<GridFightEquipmentInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightEquipmentInfo> _parser = new MessageParser<GridFightEquipmentInfo>(() => new GridFightEquipmentInfo());

	private UnknownFieldSet _unknownFields;

	public const int ConvertPropertyToFixpointFieldNumber = 1;

	private static readonly MapField<uint, uint>.Codec _map_convertPropertyToFixpoint_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 10u);

	private readonly MapField<uint, uint> convertPropertyToFixpoint_ = new MapField<uint, uint>();

	public const int SourceFieldNumber = 6;

	private uint source_;

	public const int GridFightEquipmentIdFieldNumber = 8;

	private uint gridFightEquipmentId_;

	public const int UniqueIdFieldNumber = 11;

	private uint uniqueId_;

	public const int IsTemporaryFieldNumber = 12;

	private bool isTemporary_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightEquipmentInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightEquipmentInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> ConvertPropertyToFixpoint => convertPropertyToFixpoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightEquipmentId
	{
		get
		{
			return gridFightEquipmentId_;
		}
		set
		{
			gridFightEquipmentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTemporary
	{
		get
		{
			return isTemporary_;
		}
		set
		{
			isTemporary_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipmentInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipmentInfo(GridFightEquipmentInfo other)
		: this()
	{
		convertPropertyToFixpoint_ = other.convertPropertyToFixpoint_.Clone();
		source_ = other.source_;
		gridFightEquipmentId_ = other.gridFightEquipmentId_;
		uniqueId_ = other.uniqueId_;
		isTemporary_ = other.isTemporary_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipmentInfo Clone()
	{
		return new GridFightEquipmentInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightEquipmentInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightEquipmentInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ConvertPropertyToFixpoint.Equals(other.ConvertPropertyToFixpoint))
		{
			return false;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (GridFightEquipmentId != other.GridFightEquipmentId)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (IsTemporary != other.IsTemporary)
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
		num ^= ConvertPropertyToFixpoint.GetHashCode();
		if (Source != 0)
		{
			num ^= Source.GetHashCode();
		}
		if (GridFightEquipmentId != 0)
		{
			num ^= GridFightEquipmentId.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (IsTemporary)
		{
			num ^= IsTemporary.GetHashCode();
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
		convertPropertyToFixpoint_.WriteTo(ref output, _map_convertPropertyToFixpoint_codec);
		if (Source != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Source);
		}
		if (GridFightEquipmentId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GridFightEquipmentId);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(UniqueId);
		}
		if (IsTemporary)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsTemporary);
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
		num += convertPropertyToFixpoint_.CalculateSize(_map_convertPropertyToFixpoint_codec);
		if (Source != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Source);
		}
		if (GridFightEquipmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightEquipmentId);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (IsTemporary)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightEquipmentInfo other)
	{
		if (other != null)
		{
			convertPropertyToFixpoint_.MergeFrom(other.convertPropertyToFixpoint_);
			if (other.Source != 0)
			{
				Source = other.Source;
			}
			if (other.GridFightEquipmentId != 0)
			{
				GridFightEquipmentId = other.GridFightEquipmentId;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.IsTemporary)
			{
				IsTemporary = other.IsTemporary;
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
				convertPropertyToFixpoint_.AddEntriesFrom(ref input, _map_convertPropertyToFixpoint_codec);
				break;
			case 48u:
				Source = input.ReadUInt32();
				break;
			case 64u:
				GridFightEquipmentId = input.ReadUInt32();
				break;
			case 88u:
				UniqueId = input.ReadUInt32();
				break;
			case 96u:
				IsTemporary = input.ReadBool();
				break;
			}
		}
	}
}
