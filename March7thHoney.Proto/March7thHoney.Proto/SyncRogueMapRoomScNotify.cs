using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueMapRoomScNotify : IMessage<SyncRogueMapRoomScNotify>, IMessage, IEquatable<SyncRogueMapRoomScNotify>, IDeepCloneable<SyncRogueMapRoomScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueMapRoomScNotify> _parser = new MessageParser<SyncRogueMapRoomScNotify>(() => new SyncRogueMapRoomScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ABHDOOJJICMFieldNumber = 9;

	private IJKNDKJLMEN aBHDOOJJICM_;

	public const int MapIdFieldNumber = 11;

	private uint mapId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueMapRoomScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueMapRoomScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJKNDKJLMEN ABHDOOJJICM
	{
		get
		{
			return aBHDOOJJICM_;
		}
		set
		{
			aBHDOOJJICM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueMapRoomScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueMapRoomScNotify(SyncRogueMapRoomScNotify other)
		: this()
	{
		aBHDOOJJICM_ = ((other.aBHDOOJJICM_ != null) ? other.aBHDOOJJICM_.Clone() : null);
		mapId_ = other.mapId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueMapRoomScNotify Clone()
	{
		return new SyncRogueMapRoomScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueMapRoomScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueMapRoomScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ABHDOOJJICM, other.ABHDOOJJICM))
		{
			return false;
		}
		if (MapId != other.MapId)
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
		if (aBHDOOJJICM_ != null)
		{
			num ^= ABHDOOJJICM.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
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
		if (aBHDOOJJICM_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ABHDOOJJICM);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MapId);
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
		if (aBHDOOJJICM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ABHDOOJJICM);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueMapRoomScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aBHDOOJJICM_ != null)
		{
			if (aBHDOOJJICM_ == null)
			{
				ABHDOOJJICM = new IJKNDKJLMEN();
			}
			ABHDOOJJICM.MergeFrom(other.ABHDOOJJICM);
		}
		if (other.MapId != 0)
		{
			MapId = other.MapId;
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
			case 74u:
				if (aBHDOOJJICM_ == null)
				{
					ABHDOOJJICM = new IJKNDKJLMEN();
				}
				input.ReadMessage(ABHDOOJJICM);
				break;
			case 88u:
				MapId = input.ReadUInt32();
				break;
			}
		}
	}
}
