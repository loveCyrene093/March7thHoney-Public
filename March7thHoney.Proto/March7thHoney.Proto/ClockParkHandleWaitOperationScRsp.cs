using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClockParkHandleWaitOperationScRsp : IMessage<ClockParkHandleWaitOperationScRsp>, IMessage, IEquatable<ClockParkHandleWaitOperationScRsp>, IDeepCloneable<ClockParkHandleWaitOperationScRsp>, IBufferMessage
{
	private static readonly MessageParser<ClockParkHandleWaitOperationScRsp> _parser = new MessageParser<ClockParkHandleWaitOperationScRsp>(() => new ClockParkHandleWaitOperationScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NKAHDEEOHAOFieldNumber = 2;

	private ClockParkPlayStatus nKAHDEEOHAO_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int NDEEBDDEOFAFieldNumber = 8;

	private uint nDEEBDDEOFA_;

	public const int BattleInfoFieldNumber = 11;

	private SceneBattleInfo battleInfo_;

	public const int NNFAMOJAHCHFieldNumber = 12;

	private uint nNFAMOJAHCH_;

	public const int IHNMHNPMHJGFieldNumber = 15;

	private uint iHNMHNPMHJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClockParkHandleWaitOperationScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClockParkHandleWaitOperationScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkPlayStatus NKAHDEEOHAO
	{
		get
		{
			return nKAHDEEOHAO_;
		}
		set
		{
			nKAHDEEOHAO_ = value;
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
	public uint NDEEBDDEOFA
	{
		get
		{
			return nDEEBDDEOFA_;
		}
		set
		{
			nDEEBDDEOFA_ = value;
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
	public uint NNFAMOJAHCH
	{
		get
		{
			return nNFAMOJAHCH_;
		}
		set
		{
			nNFAMOJAHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHNMHNPMHJG
	{
		get
		{
			return iHNMHNPMHJG_;
		}
		set
		{
			iHNMHNPMHJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkHandleWaitOperationScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkHandleWaitOperationScRsp(ClockParkHandleWaitOperationScRsp other)
		: this()
	{
		nKAHDEEOHAO_ = other.nKAHDEEOHAO_;
		retcode_ = other.retcode_;
		nDEEBDDEOFA_ = other.nDEEBDDEOFA_;
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		nNFAMOJAHCH_ = other.nNFAMOJAHCH_;
		iHNMHNPMHJG_ = other.iHNMHNPMHJG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkHandleWaitOperationScRsp Clone()
	{
		return new ClockParkHandleWaitOperationScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClockParkHandleWaitOperationScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClockParkHandleWaitOperationScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NKAHDEEOHAO != other.NKAHDEEOHAO)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (NDEEBDDEOFA != other.NDEEBDDEOFA)
		{
			return false;
		}
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		if (NNFAMOJAHCH != other.NNFAMOJAHCH)
		{
			return false;
		}
		if (IHNMHNPMHJG != other.IHNMHNPMHJG)
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
		if (NKAHDEEOHAO != ClockParkPlayStatus.FogfbpodidnEcfaomlddgl)
		{
			num ^= NKAHDEEOHAO.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (NDEEBDDEOFA != 0)
		{
			num ^= NDEEBDDEOFA.GetHashCode();
		}
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		if (NNFAMOJAHCH != 0)
		{
			num ^= NNFAMOJAHCH.GetHashCode();
		}
		if (IHNMHNPMHJG != 0)
		{
			num ^= IHNMHNPMHJG.GetHashCode();
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
		if (NKAHDEEOHAO != ClockParkPlayStatus.FogfbpodidnEcfaomlddgl)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)NKAHDEEOHAO);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (NDEEBDDEOFA != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NDEEBDDEOFA);
		}
		if (battleInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(BattleInfo);
		}
		if (NNFAMOJAHCH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NNFAMOJAHCH);
		}
		if (IHNMHNPMHJG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IHNMHNPMHJG);
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
		if (NKAHDEEOHAO != ClockParkPlayStatus.FogfbpodidnEcfaomlddgl)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NKAHDEEOHAO);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (NDEEBDDEOFA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDEEBDDEOFA);
		}
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		if (NNFAMOJAHCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNFAMOJAHCH);
		}
		if (IHNMHNPMHJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHNMHNPMHJG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClockParkHandleWaitOperationScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NKAHDEEOHAO != ClockParkPlayStatus.FogfbpodidnEcfaomlddgl)
		{
			NKAHDEEOHAO = other.NKAHDEEOHAO;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.NDEEBDDEOFA != 0)
		{
			NDEEBDDEOFA = other.NDEEBDDEOFA;
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new SceneBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		if (other.NNFAMOJAHCH != 0)
		{
			NNFAMOJAHCH = other.NNFAMOJAHCH;
		}
		if (other.IHNMHNPMHJG != 0)
		{
			IHNMHNPMHJG = other.IHNMHNPMHJG;
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
				NKAHDEEOHAO = (ClockParkPlayStatus)input.ReadEnum();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				NDEEBDDEOFA = input.ReadUInt32();
				break;
			case 90u:
				if (battleInfo_ == null)
				{
					BattleInfo = new SceneBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 96u:
				NNFAMOJAHCH = input.ReadUInt32();
				break;
			case 120u:
				IHNMHNPMHJG = input.ReadUInt32();
				break;
			}
		}
	}
}
