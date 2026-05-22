using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnTakeRewardScRsp : IMessage<PlayerReturnTakeRewardScRsp>, IMessage, IEquatable<PlayerReturnTakeRewardScRsp>, IDeepCloneable<PlayerReturnTakeRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnTakeRewardScRsp> _parser = new MessageParser<PlayerReturnTakeRewardScRsp>(() => new PlayerReturnTakeRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EBCAEFONDJCFieldNumber = 1;

	private ItemList eBCAEFONDJC_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnTakeRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnTakeRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList EBCAEFONDJC
	{
		get
		{
			return eBCAEFONDJC_;
		}
		set
		{
			eBCAEFONDJC_ = value;
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
	public PlayerReturnTakeRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakeRewardScRsp(PlayerReturnTakeRewardScRsp other)
		: this()
	{
		eBCAEFONDJC_ = ((other.eBCAEFONDJC_ != null) ? other.eBCAEFONDJC_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakeRewardScRsp Clone()
	{
		return new PlayerReturnTakeRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnTakeRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnTakeRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EBCAEFONDJC, other.EBCAEFONDJC))
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
		if (eBCAEFONDJC_ != null)
		{
			num ^= EBCAEFONDJC.GetHashCode();
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
		if (eBCAEFONDJC_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(EBCAEFONDJC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
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
		if (eBCAEFONDJC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EBCAEFONDJC);
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
	public void MergeFrom(PlayerReturnTakeRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eBCAEFONDJC_ != null)
		{
			if (eBCAEFONDJC_ == null)
			{
				EBCAEFONDJC = new ItemList();
			}
			EBCAEFONDJC.MergeFrom(other.EBCAEFONDJC);
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
				if (eBCAEFONDJC_ == null)
				{
					EBCAEFONDJC = new ItemList();
				}
				input.ReadMessage(EBCAEFONDJC);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
