using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueGiveUpScRsp : IMessage<ChessRogueGiveUpScRsp>, IMessage, IEquatable<ChessRogueGiveUpScRsp>, IDeepCloneable<ChessRogueGiveUpScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueGiveUpScRsp> _parser = new MessageParser<ChessRogueGiveUpScRsp>(() => new ChessRogueGiveUpScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NDMLEGLIOGNFieldNumber = 1;

	private FIILPHKLFEK nDMLEGLIOGN_;

	public const int OCLLADBFKHPFieldNumber = 4;

	private PDAMBCFFPDI oCLLADBFKHP_;

	public const int IMPBELJGDJHFieldNumber = 8;

	private JMOGPMCJGLE iMPBELJGDJH_;

	public const int RogueGetInfoFieldNumber = 9;

	private BABAGEDCCBG rogueGetInfo_;

	public const int StageInfoFieldNumber = 13;

	private EJCCHHAAGNH stageInfo_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueGiveUpScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueGiveUpScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIILPHKLFEK NDMLEGLIOGN
	{
		get
		{
			return nDMLEGLIOGN_;
		}
		set
		{
			nDMLEGLIOGN_ = value;
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
	public ChessRogueGiveUpScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueGiveUpScRsp(ChessRogueGiveUpScRsp other)
		: this()
	{
		nDMLEGLIOGN_ = ((other.nDMLEGLIOGN_ != null) ? other.nDMLEGLIOGN_.Clone() : null);
		oCLLADBFKHP_ = ((other.oCLLADBFKHP_ != null) ? other.oCLLADBFKHP_.Clone() : null);
		iMPBELJGDJH_ = ((other.iMPBELJGDJH_ != null) ? other.iMPBELJGDJH_.Clone() : null);
		rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueGiveUpScRsp Clone()
	{
		return new ChessRogueGiveUpScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueGiveUpScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueGiveUpScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NDMLEGLIOGN, other.NDMLEGLIOGN))
		{
			return false;
		}
		if (!object.Equals(OCLLADBFKHP, other.OCLLADBFKHP))
		{
			return false;
		}
		if (!object.Equals(IMPBELJGDJH, other.IMPBELJGDJH))
		{
			return false;
		}
		if (!object.Equals(RogueGetInfo, other.RogueGetInfo))
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
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
		if (nDMLEGLIOGN_ != null)
		{
			num ^= NDMLEGLIOGN.GetHashCode();
		}
		if (oCLLADBFKHP_ != null)
		{
			num ^= OCLLADBFKHP.GetHashCode();
		}
		if (iMPBELJGDJH_ != null)
		{
			num ^= IMPBELJGDJH.GetHashCode();
		}
		if (rogueGetInfo_ != null)
		{
			num ^= RogueGetInfo.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
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
		if (nDMLEGLIOGN_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(NDMLEGLIOGN);
		}
		if (oCLLADBFKHP_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OCLLADBFKHP);
		}
		if (iMPBELJGDJH_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(IMPBELJGDJH);
		}
		if (rogueGetInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(RogueGetInfo);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(StageInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		if (nDMLEGLIOGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NDMLEGLIOGN);
		}
		if (oCLLADBFKHP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OCLLADBFKHP);
		}
		if (iMPBELJGDJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPBELJGDJH);
		}
		if (rogueGetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGetInfo);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
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
	public void MergeFrom(ChessRogueGiveUpScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nDMLEGLIOGN_ != null)
		{
			if (nDMLEGLIOGN_ == null)
			{
				NDMLEGLIOGN = new FIILPHKLFEK();
			}
			NDMLEGLIOGN.MergeFrom(other.NDMLEGLIOGN);
		}
		if (other.oCLLADBFKHP_ != null)
		{
			if (oCLLADBFKHP_ == null)
			{
				OCLLADBFKHP = new PDAMBCFFPDI();
			}
			OCLLADBFKHP.MergeFrom(other.OCLLADBFKHP);
		}
		if (other.iMPBELJGDJH_ != null)
		{
			if (iMPBELJGDJH_ == null)
			{
				IMPBELJGDJH = new JMOGPMCJGLE();
			}
			IMPBELJGDJH.MergeFrom(other.IMPBELJGDJH);
		}
		if (other.rogueGetInfo_ != null)
		{
			if (rogueGetInfo_ == null)
			{
				RogueGetInfo = new BABAGEDCCBG();
			}
			RogueGetInfo.MergeFrom(other.RogueGetInfo);
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new EJCCHHAAGNH();
			}
			StageInfo.MergeFrom(other.StageInfo);
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
				if (nDMLEGLIOGN_ == null)
				{
					NDMLEGLIOGN = new FIILPHKLFEK();
				}
				input.ReadMessage(NDMLEGLIOGN);
				break;
			case 34u:
				if (oCLLADBFKHP_ == null)
				{
					OCLLADBFKHP = new PDAMBCFFPDI();
				}
				input.ReadMessage(OCLLADBFKHP);
				break;
			case 66u:
				if (iMPBELJGDJH_ == null)
				{
					IMPBELJGDJH = new JMOGPMCJGLE();
				}
				input.ReadMessage(IMPBELJGDJH);
				break;
			case 74u:
				if (rogueGetInfo_ == null)
				{
					RogueGetInfo = new BABAGEDCCBG();
				}
				input.ReadMessage(RogueGetInfo);
				break;
			case 106u:
				if (stageInfo_ == null)
				{
					StageInfo = new EJCCHHAAGNH();
				}
				input.ReadMessage(StageInfo);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
