using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateFloorSavedValueNotify : IMessage<UpdateFloorSavedValueNotify>, IMessage, IEquatable<UpdateFloorSavedValueNotify>, IDeepCloneable<UpdateFloorSavedValueNotify>, IBufferMessage
{
	private static readonly MessageParser<UpdateFloorSavedValueNotify> _parser = new MessageParser<UpdateFloorSavedValueNotify>(() => new UpdateFloorSavedValueNotify());

	private UnknownFieldSet _unknownFields;

	public const int SavedValueFieldNumber = 1;

	private static readonly MapField<string, int>.Codec _map_savedValue_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 10u);

	private readonly MapField<string, int> savedValue_ = new MapField<string, int>();

	public const int DimensionIdFieldNumber = 2;

	private uint dimensionId_;

	public const int PlaneIdFieldNumber = 7;

	private uint planeId_;

	public const int FloorIdFieldNumber = 9;

	private uint floorId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateFloorSavedValueNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateFloorSavedValueNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, int> SavedValue => savedValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DimensionId
	{
		get
		{
			return dimensionId_;
		}
		set
		{
			dimensionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateFloorSavedValueNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateFloorSavedValueNotify(UpdateFloorSavedValueNotify other)
		: this()
	{
		savedValue_ = other.savedValue_.Clone();
		dimensionId_ = other.dimensionId_;
		planeId_ = other.planeId_;
		floorId_ = other.floorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateFloorSavedValueNotify Clone()
	{
		return new UpdateFloorSavedValueNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateFloorSavedValueNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateFloorSavedValueNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!SavedValue.Equals(other.SavedValue))
		{
			return false;
		}
		if (DimensionId != other.DimensionId)
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (FloorId != other.FloorId)
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
		num ^= SavedValue.GetHashCode();
		if (DimensionId != 0)
		{
			num ^= DimensionId.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
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
		savedValue_.WriteTo(ref output, _map_savedValue_codec);
		if (DimensionId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DimensionId);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PlaneId);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FloorId);
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
		num += savedValue_.CalculateSize(_map_savedValue_codec);
		if (DimensionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DimensionId);
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateFloorSavedValueNotify other)
	{
		if (other != null)
		{
			savedValue_.MergeFrom(other.savedValue_);
			if (other.DimensionId != 0)
			{
				DimensionId = other.DimensionId;
			}
			if (other.PlaneId != 0)
			{
				PlaneId = other.PlaneId;
			}
			if (other.FloorId != 0)
			{
				FloorId = other.FloorId;
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
				savedValue_.AddEntriesFrom(ref input, _map_savedValue_codec);
				break;
			case 16u:
				DimensionId = input.ReadUInt32();
				break;
			case 56u:
				PlaneId = input.ReadUInt32();
				break;
			case 72u:
				FloorId = input.ReadUInt32();
				break;
			}
		}
	}
}
