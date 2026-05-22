using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class V2FinishPveStageScRsp : IMessage<V2FinishPveStageScRsp>, IMessage, IEquatable<V2FinishPveStageScRsp>, IDeepCloneable<V2FinishPveStageScRsp>, IBufferMessage
{
	private static readonly MessageParser<V2FinishPveStageScRsp> _parser = new MessageParser<V2FinishPveStageScRsp>(() => new V2FinishPveStageScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int MMLKFJIAKKHFieldNumber = 8;

	private uint mMLKFJIAKKH_;

	public const int RewardFieldNumber = 9;

	private ItemList reward_;

	public const int IsWinFieldNumber = 13;

	private bool isWin_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<V2FinishPveStageScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => V2FinishPveStageScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint MMLKFJIAKKH
	{
		get
		{
			return mMLKFJIAKKH_;
		}
		set
		{
			mMLKFJIAKKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public V2FinishPveStageScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public V2FinishPveStageScRsp(V2FinishPveStageScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		mMLKFJIAKKH_ = other.mMLKFJIAKKH_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		isWin_ = other.isWin_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public V2FinishPveStageScRsp Clone()
	{
		return new V2FinishPveStageScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as V2FinishPveStageScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(V2FinishPveStageScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (MMLKFJIAKKH != other.MMLKFJIAKKH)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (IsWin != other.IsWin)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (MMLKFJIAKKH != 0)
		{
			num ^= MMLKFJIAKKH.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (MMLKFJIAKKH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MMLKFJIAKKH);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Reward);
		}
		if (IsWin)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsWin);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (MMLKFJIAKKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMLKFJIAKKH);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(V2FinishPveStageScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.MMLKFJIAKKH != 0)
		{
			MMLKFJIAKKH = other.MMLKFJIAKKH;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.IsWin)
		{
			IsWin = other.IsWin;
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				MMLKFJIAKKH = input.ReadUInt32();
				break;
			case 74u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 104u:
				IsWin = input.ReadBool();
				break;
			}
		}
	}
}
