using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterRogueEndlessActivityStageScRsp : IMessage<EnterRogueEndlessActivityStageScRsp>, IMessage, IEquatable<EnterRogueEndlessActivityStageScRsp>, IDeepCloneable<EnterRogueEndlessActivityStageScRsp>, IBufferMessage
{
	private static readonly MessageParser<EnterRogueEndlessActivityStageScRsp> _parser = new MessageParser<EnterRogueEndlessActivityStageScRsp>(() => new EnterRogueEndlessActivityStageScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BattleInfoFieldNumber = 3;

	private SceneBattleInfo battleInfo_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int BNOCEPKMPGKFieldNumber = 12;

	private DGDHBAGEOOI bNOCEPKMPGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterRogueEndlessActivityStageScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterRogueEndlessActivityStageScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneBattleInfo BattleInfo
	{
		get
		{
			return battleInfo_;
		}
		set
		{
			battleInfo_ = value;
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
	public DGDHBAGEOOI BNOCEPKMPGK
	{
		get
		{
			return bNOCEPKMPGK_;
		}
		set
		{
			bNOCEPKMPGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterRogueEndlessActivityStageScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterRogueEndlessActivityStageScRsp(EnterRogueEndlessActivityStageScRsp other)
		: this()
	{
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		retcode_ = other.retcode_;
		bNOCEPKMPGK_ = ((other.bNOCEPKMPGK_ != null) ? other.bNOCEPKMPGK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterRogueEndlessActivityStageScRsp Clone()
	{
		return new EnterRogueEndlessActivityStageScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterRogueEndlessActivityStageScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterRogueEndlessActivityStageScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(BNOCEPKMPGK, other.BNOCEPKMPGK))
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
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (bNOCEPKMPGK_ != null)
		{
			num ^= BNOCEPKMPGK.GetHashCode();
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
		if (battleInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BattleInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		if (bNOCEPKMPGK_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(BNOCEPKMPGK);
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
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (bNOCEPKMPGK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNOCEPKMPGK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterRogueEndlessActivityStageScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new SceneBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.bNOCEPKMPGK_ != null)
		{
			if (bNOCEPKMPGK_ == null)
			{
				BNOCEPKMPGK = new DGDHBAGEOOI();
			}
			BNOCEPKMPGK.MergeFrom(other.BNOCEPKMPGK);
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
			case 26u:
				if (battleInfo_ == null)
				{
					BattleInfo = new SceneBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				if (bNOCEPKMPGK_ == null)
				{
					BNOCEPKMPGK = new DGDHBAGEOOI();
				}
				input.ReadMessage(BNOCEPKMPGK);
				break;
			}
		}
	}
}
