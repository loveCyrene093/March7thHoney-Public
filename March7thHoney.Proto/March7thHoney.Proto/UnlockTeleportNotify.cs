using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UnlockTeleportNotify : IMessage<UnlockTeleportNotify>, IMessage, IEquatable<UnlockTeleportNotify>, IDeepCloneable<UnlockTeleportNotify>, IBufferMessage
{
	private static readonly MessageParser<UnlockTeleportNotify> _parser = new MessageParser<UnlockTeleportNotify>(() => new UnlockTeleportNotify());

	private UnknownFieldSet _unknownFields;

	public const int EntryIdFieldNumber = 3;

	private uint entryId_;

	public const int TeleportIdFieldNumber = 6;

	private uint teleportId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UnlockTeleportNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UnlockTeleportNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntryId
	{
		get
		{
			return entryId_;
		}
		set
		{
			entryId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TeleportId
	{
		get
		{
			return teleportId_;
		}
		set
		{
			teleportId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockTeleportNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockTeleportNotify(UnlockTeleportNotify other)
		: this()
	{
		entryId_ = other.entryId_;
		teleportId_ = other.teleportId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockTeleportNotify Clone()
	{
		return new UnlockTeleportNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UnlockTeleportNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UnlockTeleportNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		if (TeleportId != other.TeleportId)
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
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
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
		if (EntryId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EntryId);
		}
		if (TeleportId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(TeleportId);
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
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UnlockTeleportNotify other)
	{
		if (other != null)
		{
			if (other.EntryId != 0)
			{
				EntryId = other.EntryId;
			}
			if (other.TeleportId != 0)
			{
				TeleportId = other.TeleportId;
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
			case 24u:
				EntryId = input.ReadUInt32();
				break;
			case 48u:
				TeleportId = input.ReadUInt32();
				break;
			}
		}
	}
}
