using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneGroupRefreshScNotify : IMessage<SceneGroupRefreshScNotify>, IMessage, IEquatable<SceneGroupRefreshScNotify>, IDeepCloneable<SceneGroupRefreshScNotify>, IBufferMessage
{
	private static readonly MessageParser<SceneGroupRefreshScNotify> _parser = new MessageParser<SceneGroupRefreshScNotify>(() => new SceneGroupRefreshScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GroupRefreshListFieldNumber = 2;

	private static readonly FieldCodec<GroupRefreshInfo> _repeated_groupRefreshList_codec = FieldCodec.ForMessage(18u, GroupRefreshInfo.Parser);

	private readonly RepeatedField<GroupRefreshInfo> groupRefreshList_ = new RepeatedField<GroupRefreshInfo>();

	public const int DimensionIdFieldNumber = 4;

	private uint dimensionId_;

	public const int FloorIdFieldNumber = 11;

	private uint floorId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneGroupRefreshScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneGroupRefreshScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GroupRefreshInfo> GroupRefreshList => groupRefreshList_;

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
	public SceneGroupRefreshScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneGroupRefreshScNotify(SceneGroupRefreshScNotify other)
		: this()
	{
		groupRefreshList_ = other.groupRefreshList_.Clone();
		dimensionId_ = other.dimensionId_;
		floorId_ = other.floorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneGroupRefreshScNotify Clone()
	{
		return new SceneGroupRefreshScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneGroupRefreshScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneGroupRefreshScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!groupRefreshList_.Equals(other.groupRefreshList_))
		{
			return false;
		}
		if (DimensionId != other.DimensionId)
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
		num ^= groupRefreshList_.GetHashCode();
		if (DimensionId != 0)
		{
			num ^= DimensionId.GetHashCode();
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
		groupRefreshList_.WriteTo(ref output, _repeated_groupRefreshList_codec);
		if (DimensionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DimensionId);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(88);
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
		num += groupRefreshList_.CalculateSize(_repeated_groupRefreshList_codec);
		if (DimensionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DimensionId);
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
	public void MergeFrom(SceneGroupRefreshScNotify other)
	{
		if (other != null)
		{
			groupRefreshList_.Add(other.groupRefreshList_);
			if (other.DimensionId != 0)
			{
				DimensionId = other.DimensionId;
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
			case 18u:
				groupRefreshList_.AddEntriesFrom(ref input, _repeated_groupRefreshList_codec);
				break;
			case 32u:
				DimensionId = input.ReadUInt32();
				break;
			case 88u:
				FloorId = input.ReadUInt32();
				break;
			}
		}
	}
}
