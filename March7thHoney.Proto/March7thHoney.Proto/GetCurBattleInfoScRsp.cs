using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetCurBattleInfoScRsp : IMessage<GetCurBattleInfoScRsp>, IMessage, IEquatable<GetCurBattleInfoScRsp>, IDeepCloneable<GetCurBattleInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetCurBattleInfoScRsp> _parser = new MessageParser<GetCurBattleInfoScRsp>(() => new GetCurBattleInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int DPCNCLIBJBCFieldNumber = 10;

	private AetherDivideBattleInfo dPCNCLIBJBC_;

	public const int BattleInfoFieldNumber = 12;

	private SceneBattleInfo battleInfo_;

	public const int HMBGOPOLOJOFieldNumber = 13;

	private uint hMBGOPOLOJO_;

	public const int LastEndStatusFieldNumber = 15;

	private BattleEndStatus lastEndStatus_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetCurBattleInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetCurBattleInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public AetherDivideBattleInfo DPCNCLIBJBC
	{
		get
		{
			return dPCNCLIBJBC_;
		}
		set
		{
			dPCNCLIBJBC_ = value;
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
	public uint HMBGOPOLOJO
	{
		get
		{
			return hMBGOPOLOJO_;
		}
		set
		{
			hMBGOPOLOJO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEndStatus LastEndStatus
	{
		get
		{
			return lastEndStatus_;
		}
		set
		{
			lastEndStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurBattleInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurBattleInfoScRsp(GetCurBattleInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		dPCNCLIBJBC_ = ((other.dPCNCLIBJBC_ != null) ? other.dPCNCLIBJBC_.Clone() : null);
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		hMBGOPOLOJO_ = other.hMBGOPOLOJO_;
		lastEndStatus_ = other.lastEndStatus_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurBattleInfoScRsp Clone()
	{
		return new GetCurBattleInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetCurBattleInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetCurBattleInfoScRsp other)
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
		if (!object.Equals(DPCNCLIBJBC, other.DPCNCLIBJBC))
		{
			return false;
		}
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		if (HMBGOPOLOJO != other.HMBGOPOLOJO)
		{
			return false;
		}
		if (LastEndStatus != other.LastEndStatus)
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
		if (dPCNCLIBJBC_ != null)
		{
			num ^= DPCNCLIBJBC.GetHashCode();
		}
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		if (HMBGOPOLOJO != 0)
		{
			num ^= HMBGOPOLOJO.GetHashCode();
		}
		if (LastEndStatus != BattleEndStatus.BattleEndNone)
		{
			num ^= LastEndStatus.GetHashCode();
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
		if (dPCNCLIBJBC_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DPCNCLIBJBC);
		}
		if (battleInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(BattleInfo);
		}
		if (HMBGOPOLOJO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HMBGOPOLOJO);
		}
		if (LastEndStatus != BattleEndStatus.BattleEndNone)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)LastEndStatus);
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
		if (dPCNCLIBJBC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DPCNCLIBJBC);
		}
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		if (HMBGOPOLOJO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HMBGOPOLOJO);
		}
		if (LastEndStatus != BattleEndStatus.BattleEndNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LastEndStatus);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetCurBattleInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.dPCNCLIBJBC_ != null)
		{
			if (dPCNCLIBJBC_ == null)
			{
				DPCNCLIBJBC = new AetherDivideBattleInfo();
			}
			DPCNCLIBJBC.MergeFrom(other.DPCNCLIBJBC);
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new SceneBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		if (other.HMBGOPOLOJO != 0)
		{
			HMBGOPOLOJO = other.HMBGOPOLOJO;
		}
		if (other.LastEndStatus != BattleEndStatus.BattleEndNone)
		{
			LastEndStatus = other.LastEndStatus;
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
			case 82u:
				if (dPCNCLIBJBC_ == null)
				{
					DPCNCLIBJBC = new AetherDivideBattleInfo();
				}
				input.ReadMessage(DPCNCLIBJBC);
				break;
			case 98u:
				if (battleInfo_ == null)
				{
					BattleInfo = new SceneBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 104u:
				HMBGOPOLOJO = input.ReadUInt32();
				break;
			case 120u:
				LastEndStatus = (BattleEndStatus)input.ReadEnum();
				break;
			}
		}
	}
}
