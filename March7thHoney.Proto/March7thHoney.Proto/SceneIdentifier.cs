using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneIdentifier : IMessage<SceneIdentifier>, IMessage, IEquatable<SceneIdentifier>, IDeepCloneable<SceneIdentifier>, IBufferMessage
{
	private static readonly MessageParser<SceneIdentifier> _parser = new MessageParser<SceneIdentifier>(() => new SceneIdentifier());

	private UnknownFieldSet _unknownFields;

	public const int FloorIdFieldNumber = 2;

	private uint floorId_;

	public const int GameStoryLineIdFieldNumber = 6;

	private uint gameStoryLineId_;

	public const int ContentIdFieldNumber = 14;

	private uint contentId_;

	public const int TeleportInfoFieldNumber = 1621;

	private TeleportInfo teleportInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneIdentifier> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneIdentifierReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint GameStoryLineId
	{
		get
		{
			return gameStoryLineId_;
		}
		set
		{
			gameStoryLineId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ContentId
	{
		get
		{
			return contentId_;
		}
		set
		{
			contentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportInfo TeleportInfo
	{
		get
		{
			return teleportInfo_;
		}
		set
		{
			teleportInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneIdentifier()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneIdentifier(SceneIdentifier other)
		: this()
	{
		floorId_ = other.floorId_;
		gameStoryLineId_ = other.gameStoryLineId_;
		contentId_ = other.contentId_;
		teleportInfo_ = ((other.teleportInfo_ != null) ? other.teleportInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneIdentifier Clone()
	{
		return new SceneIdentifier(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneIdentifier);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneIdentifier other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FloorId != other.FloorId)
		{
			return false;
		}
		if (GameStoryLineId != other.GameStoryLineId)
		{
			return false;
		}
		if (ContentId != other.ContentId)
		{
			return false;
		}
		if (!object.Equals(TeleportInfo, other.TeleportInfo))
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
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		if (GameStoryLineId != 0)
		{
			num ^= GameStoryLineId.GetHashCode();
		}
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		if (teleportInfo_ != null)
		{
			num ^= TeleportInfo.GetHashCode();
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
		if (FloorId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FloorId);
		}
		if (GameStoryLineId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GameStoryLineId);
		}
		if (ContentId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ContentId);
		}
		if (teleportInfo_ != null)
		{
			output.WriteRawTag(170, 101);
			output.WriteMessage(TeleportInfo);
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
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (GameStoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
		}
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		if (teleportInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TeleportInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneIdentifier other)
	{
		if (other == null)
		{
			return;
		}
		if (other.FloorId != 0)
		{
			FloorId = other.FloorId;
		}
		if (other.GameStoryLineId != 0)
		{
			GameStoryLineId = other.GameStoryLineId;
		}
		if (other.ContentId != 0)
		{
			ContentId = other.ContentId;
		}
		if (other.teleportInfo_ != null)
		{
			if (teleportInfo_ == null)
			{
				TeleportInfo = new TeleportInfo();
			}
			TeleportInfo.MergeFrom(other.TeleportInfo);
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
			case 16u:
				FloorId = input.ReadUInt32();
				break;
			case 48u:
				GameStoryLineId = input.ReadUInt32();
				break;
			case 112u:
				ContentId = input.ReadUInt32();
				break;
			case 12970u:
				if (teleportInfo_ == null)
				{
					TeleportInfo = new TeleportInfo();
				}
				input.ReadMessage(TeleportInfo);
				break;
			}
		}
	}
}
