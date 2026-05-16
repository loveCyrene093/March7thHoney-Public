using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartAetherDivideSceneBattleScRsp : IMessage<StartAetherDivideSceneBattleScRsp>, IMessage, IEquatable<StartAetherDivideSceneBattleScRsp>, IDeepCloneable<StartAetherDivideSceneBattleScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartAetherDivideSceneBattleScRsp> _parser = new MessageParser<StartAetherDivideSceneBattleScRsp>(() => new StartAetherDivideSceneBattleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BattleInfoFieldNumber = 6;

	private AetherDivideBattleInfo battleInfo_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int CastEntityIdFieldNumber = 10;

	private uint castEntityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartAetherDivideSceneBattleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartAetherDivideSceneBattleScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideBattleInfo BattleInfo
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
	public uint CastEntityId
	{
		get
		{
			return castEntityId_;
		}
		set
		{
			castEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideSceneBattleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideSceneBattleScRsp(StartAetherDivideSceneBattleScRsp other)
		: this()
	{
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		retcode_ = other.retcode_;
		castEntityId_ = other.castEntityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideSceneBattleScRsp Clone()
	{
		return new StartAetherDivideSceneBattleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartAetherDivideSceneBattleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartAetherDivideSceneBattleScRsp other)
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
		if (CastEntityId != other.CastEntityId)
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
		if (CastEntityId != 0)
		{
			num ^= CastEntityId.GetHashCode();
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
			output.WriteRawTag(50);
			output.WriteMessage(BattleInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (CastEntityId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CastEntityId);
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
		if (CastEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CastEntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartAetherDivideSceneBattleScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new AetherDivideBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.CastEntityId != 0)
		{
			CastEntityId = other.CastEntityId;
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
			case 50u:
				if (battleInfo_ == null)
				{
					BattleInfo = new AetherDivideBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 80u:
				CastEntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
