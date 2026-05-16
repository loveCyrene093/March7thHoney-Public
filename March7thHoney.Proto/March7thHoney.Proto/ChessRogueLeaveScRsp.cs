using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueLeaveScRsp : IMessage<ChessRogueLeaveScRsp>, IMessage, IEquatable<ChessRogueLeaveScRsp>, IDeepCloneable<ChessRogueLeaveScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueLeaveScRsp> _parser = new MessageParser<ChessRogueLeaveScRsp>(() => new ChessRogueLeaveScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RogueGetInfoFieldNumber = 2;

	private BABAGEDCCBG rogueGetInfo_;

	public const int IMPBELJGDJHFieldNumber = 4;

	private JMOGPMCJGLE iMPBELJGDJH_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int StageInfoFieldNumber = 11;

	private EJCCHHAAGNH stageInfo_;

	public const int OCLLADBFKHPFieldNumber = 12;

	private PDAMBCFFPDI oCLLADBFKHP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueLeaveScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueLeaveScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BABAGEDCCBG RogueGetInfo
	{
		get
		{
			return rogueGetInfo_;
		}
		set
		{
			rogueGetInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMOGPMCJGLE IMPBELJGDJH
	{
		get
		{
			return iMPBELJGDJH_;
		}
		set
		{
			iMPBELJGDJH_ = value;
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
	public EJCCHHAAGNH StageInfo
	{
		get
		{
			return stageInfo_;
		}
		set
		{
			stageInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDAMBCFFPDI OCLLADBFKHP
	{
		get
		{
			return oCLLADBFKHP_;
		}
		set
		{
			oCLLADBFKHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueLeaveScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueLeaveScRsp(ChessRogueLeaveScRsp other)
		: this()
	{
		rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
		iMPBELJGDJH_ = ((other.iMPBELJGDJH_ != null) ? other.iMPBELJGDJH_.Clone() : null);
		retcode_ = other.retcode_;
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		oCLLADBFKHP_ = ((other.oCLLADBFKHP_ != null) ? other.oCLLADBFKHP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueLeaveScRsp Clone()
	{
		return new ChessRogueLeaveScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueLeaveScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueLeaveScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RogueGetInfo, other.RogueGetInfo))
		{
			return false;
		}
		if (!object.Equals(IMPBELJGDJH, other.IMPBELJGDJH))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
		{
			return false;
		}
		if (!object.Equals(OCLLADBFKHP, other.OCLLADBFKHP))
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
		if (rogueGetInfo_ != null)
		{
			num ^= RogueGetInfo.GetHashCode();
		}
		if (iMPBELJGDJH_ != null)
		{
			num ^= IMPBELJGDJH.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
		}
		if (oCLLADBFKHP_ != null)
		{
			num ^= OCLLADBFKHP.GetHashCode();
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
		if (rogueGetInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RogueGetInfo);
		}
		if (iMPBELJGDJH_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(IMPBELJGDJH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(StageInfo);
		}
		if (oCLLADBFKHP_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(OCLLADBFKHP);
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
		if (rogueGetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGetInfo);
		}
		if (iMPBELJGDJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPBELJGDJH);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (oCLLADBFKHP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OCLLADBFKHP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueLeaveScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rogueGetInfo_ != null)
		{
			if (rogueGetInfo_ == null)
			{
				RogueGetInfo = new BABAGEDCCBG();
			}
			RogueGetInfo.MergeFrom(other.RogueGetInfo);
		}
		if (other.iMPBELJGDJH_ != null)
		{
			if (iMPBELJGDJH_ == null)
			{
				IMPBELJGDJH = new JMOGPMCJGLE();
			}
			IMPBELJGDJH.MergeFrom(other.IMPBELJGDJH);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new EJCCHHAAGNH();
			}
			StageInfo.MergeFrom(other.StageInfo);
		}
		if (other.oCLLADBFKHP_ != null)
		{
			if (oCLLADBFKHP_ == null)
			{
				OCLLADBFKHP = new PDAMBCFFPDI();
			}
			OCLLADBFKHP.MergeFrom(other.OCLLADBFKHP);
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
			case 18u:
				if (rogueGetInfo_ == null)
				{
					RogueGetInfo = new BABAGEDCCBG();
				}
				input.ReadMessage(RogueGetInfo);
				break;
			case 34u:
				if (iMPBELJGDJH_ == null)
				{
					IMPBELJGDJH = new JMOGPMCJGLE();
				}
				input.ReadMessage(IMPBELJGDJH);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (stageInfo_ == null)
				{
					StageInfo = new EJCCHHAAGNH();
				}
				input.ReadMessage(StageInfo);
				break;
			case 98u:
				if (oCLLADBFKHP_ == null)
				{
					OCLLADBFKHP = new PDAMBCFFPDI();
				}
				input.ReadMessage(OCLLADBFKHP);
				break;
			}
		}
	}
}
