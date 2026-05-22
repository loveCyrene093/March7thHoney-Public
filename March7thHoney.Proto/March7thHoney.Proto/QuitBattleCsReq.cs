using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuitBattleCsReq : IMessage<QuitBattleCsReq>, IMessage, IEquatable<QuitBattleCsReq>, IDeepCloneable<QuitBattleCsReq>, IBufferMessage
{
	private static readonly MessageParser<QuitBattleCsReq> _parser = new MessageParser<QuitBattleCsReq>(() => new QuitBattleCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MGABMCBOHMKFieldNumber = 2;

	private RebattleType mGABMCBOHMK_;

	public const int SttFieldNumber = 8;

	private BattleStatistics stt_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuitBattleCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuitBattleCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RebattleType MGABMCBOHMK
	{
		get
		{
			return mGABMCBOHMK_;
		}
		set
		{
			mGABMCBOHMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatistics Stt
	{
		get
		{
			return stt_;
		}
		set
		{
			stt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitBattleCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitBattleCsReq(QuitBattleCsReq other)
		: this()
	{
		mGABMCBOHMK_ = other.mGABMCBOHMK_;
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitBattleCsReq Clone()
	{
		return new QuitBattleCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuitBattleCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuitBattleCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGABMCBOHMK != other.MGABMCBOHMK)
		{
			return false;
		}
		if (!object.Equals(Stt, other.Stt))
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
		if (MGABMCBOHMK != RebattleType.None)
		{
			num ^= MGABMCBOHMK.GetHashCode();
		}
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
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
		if (MGABMCBOHMK != RebattleType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)MGABMCBOHMK);
		}
		if (stt_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Stt);
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
		if (MGABMCBOHMK != RebattleType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MGABMCBOHMK);
		}
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuitBattleCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MGABMCBOHMK != RebattleType.None)
		{
			MGABMCBOHMK = other.MGABMCBOHMK;
		}
		if (other.stt_ != null)
		{
			if (stt_ == null)
			{
				Stt = new BattleStatistics();
			}
			Stt.MergeFrom(other.Stt);
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
				MGABMCBOHMK = (RebattleType)input.ReadEnum();
				break;
			case 66u:
				if (stt_ == null)
				{
					Stt = new BattleStatistics();
				}
				input.ReadMessage(Stt);
				break;
			}
		}
	}
}
