using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChangePropTimelineInfoCsReq : IMessage<ChangePropTimelineInfoCsReq>, IMessage, IEquatable<ChangePropTimelineInfoCsReq>, IDeepCloneable<ChangePropTimelineInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChangePropTimelineInfoCsReq> _parser = new MessageParser<ChangePropTimelineInfoCsReq>(() => new ChangePropTimelineInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IsCloseMapFieldNumber = 1;

	private bool isCloseMap_;

	public const int PropEntityIdFieldNumber = 3;

	private uint propEntityId_;

	public const int UuidFieldNumber = 6;

	private ulong uuid_;

	public const int TimelineInfoFieldNumber = 11;

	private PropTimelineInfo timelineInfo_;

	public const int InteractIdFieldNumber = 15;

	private ulong interactId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChangePropTimelineInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChangePropTimelineInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsCloseMap
	{
		get
		{
			return isCloseMap_;
		}
		set
		{
			isCloseMap_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PropEntityId
	{
		get
		{
			return propEntityId_;
		}
		set
		{
			propEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong Uuid
	{
		get
		{
			return uuid_;
		}
		set
		{
			uuid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropTimelineInfo TimelineInfo
	{
		get
		{
			return timelineInfo_;
		}
		set
		{
			timelineInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangePropTimelineInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangePropTimelineInfoCsReq(ChangePropTimelineInfoCsReq other)
		: this()
	{
		isCloseMap_ = other.isCloseMap_;
		propEntityId_ = other.propEntityId_;
		uuid_ = other.uuid_;
		timelineInfo_ = ((other.timelineInfo_ != null) ? other.timelineInfo_.Clone() : null);
		interactId_ = other.interactId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangePropTimelineInfoCsReq Clone()
	{
		return new ChangePropTimelineInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChangePropTimelineInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChangePropTimelineInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsCloseMap != other.IsCloseMap)
		{
			return false;
		}
		if (PropEntityId != other.PropEntityId)
		{
			return false;
		}
		if (Uuid != other.Uuid)
		{
			return false;
		}
		if (!object.Equals(TimelineInfo, other.TimelineInfo))
		{
			return false;
		}
		if (InteractId != other.InteractId)
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
		if (IsCloseMap)
		{
			num ^= IsCloseMap.GetHashCode();
		}
		if (PropEntityId != 0)
		{
			num ^= PropEntityId.GetHashCode();
		}
		if (Uuid != 0L)
		{
			num ^= Uuid.GetHashCode();
		}
		if (timelineInfo_ != null)
		{
			num ^= TimelineInfo.GetHashCode();
		}
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
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
		if (IsCloseMap)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsCloseMap);
		}
		if (PropEntityId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PropEntityId);
		}
		if (Uuid != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(Uuid);
		}
		if (timelineInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(TimelineInfo);
		}
		if (InteractId != 0L)
		{
			output.WriteRawTag(120);
			output.WriteUInt64(InteractId);
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
		if (IsCloseMap)
		{
			num += 2;
		}
		if (PropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropEntityId);
		}
		if (Uuid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uuid);
		}
		if (timelineInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TimelineInfo);
		}
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChangePropTimelineInfoCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IsCloseMap)
		{
			IsCloseMap = other.IsCloseMap;
		}
		if (other.PropEntityId != 0)
		{
			PropEntityId = other.PropEntityId;
		}
		if (other.Uuid != 0L)
		{
			Uuid = other.Uuid;
		}
		if (other.timelineInfo_ != null)
		{
			if (timelineInfo_ == null)
			{
				TimelineInfo = new PropTimelineInfo();
			}
			TimelineInfo.MergeFrom(other.TimelineInfo);
		}
		if (other.InteractId != 0L)
		{
			InteractId = other.InteractId;
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
				IsCloseMap = input.ReadBool();
				break;
			case 24u:
				PropEntityId = input.ReadUInt32();
				break;
			case 48u:
				Uuid = input.ReadUInt64();
				break;
			case 90u:
				if (timelineInfo_ == null)
				{
					TimelineInfo = new PropTimelineInfo();
				}
				input.ReadMessage(TimelineInfo);
				break;
			case 120u:
				InteractId = input.ReadUInt64();
				break;
			}
		}
	}
}
