using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelSaveFriendPvpLineupScRsp : IMessage<ChimeraDuelSaveFriendPvpLineupScRsp>, IMessage, IEquatable<ChimeraDuelSaveFriendPvpLineupScRsp>, IDeepCloneable<ChimeraDuelSaveFriendPvpLineupScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelSaveFriendPvpLineupScRsp> _parser = new MessageParser<ChimeraDuelSaveFriendPvpLineupScRsp>(() => new ChimeraDuelSaveFriendPvpLineupScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LineupFieldNumber = 1;

	private DKDGGGCDAGM lineup_;

	public const int SlotFieldNumber = 3;

	private uint slot_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelSaveFriendPvpLineupScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelSaveFriendPvpLineupScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKDGGGCDAGM Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelSaveFriendPvpLineupScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelSaveFriendPvpLineupScRsp(ChimeraDuelSaveFriendPvpLineupScRsp other)
		: this()
	{
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		slot_ = other.slot_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelSaveFriendPvpLineupScRsp Clone()
	{
		return new ChimeraDuelSaveFriendPvpLineupScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelSaveFriendPvpLineupScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelSaveFriendPvpLineupScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (Slot != other.Slot)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (lineup_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Lineup);
		}
		if (Slot != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Slot);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
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
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Slot);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelSaveFriendPvpLineupScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new DKDGGGCDAGM();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		if (other.Slot != 0)
		{
			Slot = other.Slot;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
				if (lineup_ == null)
				{
					Lineup = new DKDGGGCDAGM();
				}
				input.ReadMessage(Lineup);
				break;
			case 24u:
				Slot = input.ReadUInt32();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
