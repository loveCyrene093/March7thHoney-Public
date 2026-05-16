using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerSnapshot : IMessage<PlayerSnapshot>, IMessage, IEquatable<PlayerSnapshot>, IDeepCloneable<PlayerSnapshot>, IBufferMessage
{
	private static readonly MessageParser<PlayerSnapshot> _parser = new MessageParser<PlayerSnapshot>(() => new PlayerSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int MotionInfoFieldNumber = 1;

	private MotionInfoSnapshot motionInfo_;

	public const int MapLayerFieldNumber = 2;

	private uint mapLayer_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfoSnapshot MotionInfo
	{
		get
		{
			return motionInfo_;
		}
		set
		{
			motionInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapLayer
	{
		get
		{
			return mapLayer_;
		}
		set
		{
			mapLayer_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSnapshot(PlayerSnapshot other)
		: this()
	{
		motionInfo_ = ((other.motionInfo_ != null) ? other.motionInfo_.Clone() : null);
		mapLayer_ = other.mapLayer_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSnapshot Clone()
	{
		return new PlayerSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MotionInfo, other.MotionInfo))
		{
			return false;
		}
		if (MapLayer != other.MapLayer)
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
		if (motionInfo_ != null)
		{
			num ^= MotionInfo.GetHashCode();
		}
		if (MapLayer != 0)
		{
			num ^= MapLayer.GetHashCode();
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
		if (motionInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MotionInfo);
		}
		if (MapLayer != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MapLayer);
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
		if (motionInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MotionInfo);
		}
		if (MapLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapLayer);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerSnapshot other)
	{
		if (other == null)
		{
			return;
		}
		if (other.motionInfo_ != null)
		{
			if (motionInfo_ == null)
			{
				MotionInfo = new MotionInfoSnapshot();
			}
			MotionInfo.MergeFrom(other.MotionInfo);
		}
		if (other.MapLayer != 0)
		{
			MapLayer = other.MapLayer;
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
			case 10u:
				if (motionInfo_ == null)
				{
					MotionInfo = new MotionInfoSnapshot();
				}
				input.ReadMessage(MotionInfo);
				break;
			case 16u:
				MapLayer = input.ReadUInt32();
				break;
			}
		}
	}
}
