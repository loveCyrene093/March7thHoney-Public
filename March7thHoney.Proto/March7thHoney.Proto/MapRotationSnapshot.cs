using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapRotationSnapshot : IMessage<MapRotationSnapshot>, IMessage, IEquatable<MapRotationSnapshot>, IDeepCloneable<MapRotationSnapshot>, IBufferMessage
{
	private static readonly MessageParser<MapRotationSnapshot> _parser = new MessageParser<MapRotationSnapshot>(() => new MapRotationSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int RegionIdFieldNumber = 1;

	private int regionId_;

	public const int PoseIdFieldNumber = 2;

	private uint poseId_;

	public const int MapInfoFieldNumber = 3;

	private RotationMapInfoSnapshot mapInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapRotationSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MapRotationSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RegionId
	{
		get
		{
			return regionId_;
		}
		set
		{
			regionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PoseId
	{
		get
		{
			return poseId_;
		}
		set
		{
			poseId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotationMapInfoSnapshot MapInfo
	{
		get
		{
			return mapInfo_;
		}
		set
		{
			mapInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRotationSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRotationSnapshot(MapRotationSnapshot other)
		: this()
	{
		regionId_ = other.regionId_;
		poseId_ = other.poseId_;
		mapInfo_ = ((other.mapInfo_ != null) ? other.mapInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRotationSnapshot Clone()
	{
		return new MapRotationSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MapRotationSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapRotationSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RegionId != other.RegionId)
		{
			return false;
		}
		if (PoseId != other.PoseId)
		{
			return false;
		}
		if (!object.Equals(MapInfo, other.MapInfo))
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
		if (RegionId != 0)
		{
			num ^= RegionId.GetHashCode();
		}
		if (PoseId != 0)
		{
			num ^= PoseId.GetHashCode();
		}
		if (mapInfo_ != null)
		{
			num ^= MapInfo.GetHashCode();
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
		if (RegionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RegionId);
		}
		if (PoseId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PoseId);
		}
		if (mapInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MapInfo);
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
		if (RegionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RegionId);
		}
		if (PoseId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PoseId);
		}
		if (mapInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MapInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapRotationSnapshot other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RegionId != 0)
		{
			RegionId = other.RegionId;
		}
		if (other.PoseId != 0)
		{
			PoseId = other.PoseId;
		}
		if (other.mapInfo_ != null)
		{
			if (mapInfo_ == null)
			{
				MapInfo = new RotationMapInfoSnapshot();
			}
			MapInfo.MergeFrom(other.MapInfo);
		}
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
				RegionId = input.ReadInt32();
				break;
			case 16u:
				PoseId = input.ReadUInt32();
				break;
			case 26u:
				if (mapInfo_ == null)
				{
					MapInfo = new RotationMapInfoSnapshot();
				}
				input.ReadMessage(MapInfo);
				break;
			}
		}
	}
}
