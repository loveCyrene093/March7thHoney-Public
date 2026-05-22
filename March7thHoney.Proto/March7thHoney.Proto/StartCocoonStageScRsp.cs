using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartCocoonStageScRsp : IMessage<StartCocoonStageScRsp>, IMessage, IEquatable<StartCocoonStageScRsp>, IDeepCloneable<StartCocoonStageScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartCocoonStageScRsp> _parser = new MessageParser<StartCocoonStageScRsp>(() => new StartCocoonStageScRsp());

	private UnknownFieldSet _unknownFields;

	public const int WaveFieldNumber = 4;

	private uint wave_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int PropEntityIdFieldNumber = 6;

	private uint propEntityId_;

	public const int ChallengeCntFieldNumber = 9;

	private uint challengeCnt_;

	public const int BattleInfoFieldNumber = 11;

	private SceneBattleInfo battleInfo_;

	public const int CocoonIdFieldNumber = 14;

	private uint cocoonId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartCocoonStageScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartCocoonStageScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
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
	public uint ChallengeCnt
	{
		get
		{
			return challengeCnt_;
		}
		set
		{
			challengeCnt_ = value;
		}
	}

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
	public uint CocoonId
	{
		get
		{
			return cocoonId_;
		}
		set
		{
			cocoonId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartCocoonStageScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartCocoonStageScRsp(StartCocoonStageScRsp other)
		: this()
	{
		wave_ = other.wave_;
		retcode_ = other.retcode_;
		propEntityId_ = other.propEntityId_;
		challengeCnt_ = other.challengeCnt_;
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		cocoonId_ = other.cocoonId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartCocoonStageScRsp Clone()
	{
		return new StartCocoonStageScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartCocoonStageScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartCocoonStageScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (PropEntityId != other.PropEntityId)
		{
			return false;
		}
		if (ChallengeCnt != other.ChallengeCnt)
		{
			return false;
		}
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		if (CocoonId != other.CocoonId)
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
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (PropEntityId != 0)
		{
			num ^= PropEntityId.GetHashCode();
		}
		if (ChallengeCnt != 0)
		{
			num ^= ChallengeCnt.GetHashCode();
		}
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		if (CocoonId != 0)
		{
			num ^= CocoonId.GetHashCode();
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
		if (Wave != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Wave);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (PropEntityId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PropEntityId);
		}
		if (ChallengeCnt != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ChallengeCnt);
		}
		if (battleInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(BattleInfo);
		}
		if (CocoonId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CocoonId);
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
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (PropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropEntityId);
		}
		if (ChallengeCnt != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeCnt);
		}
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		if (CocoonId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CocoonId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartCocoonStageScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Wave != 0)
		{
			Wave = other.Wave;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.PropEntityId != 0)
		{
			PropEntityId = other.PropEntityId;
		}
		if (other.ChallengeCnt != 0)
		{
			ChallengeCnt = other.ChallengeCnt;
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new SceneBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		if (other.CocoonId != 0)
		{
			CocoonId = other.CocoonId;
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
				Wave = input.ReadUInt32();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 48u:
				PropEntityId = input.ReadUInt32();
				break;
			case 72u:
				ChallengeCnt = input.ReadUInt32();
				break;
			case 90u:
				if (battleInfo_ == null)
				{
					BattleInfo = new SceneBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 112u:
				CocoonId = input.ReadUInt32();
				break;
			}
		}
	}
}
