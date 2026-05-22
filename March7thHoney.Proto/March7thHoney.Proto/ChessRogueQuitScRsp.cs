using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueQuitScRsp : IMessage<ChessRogueQuitScRsp>, IMessage, IEquatable<ChessRogueQuitScRsp>, IDeepCloneable<ChessRogueQuitScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueQuitScRsp> _parser = new MessageParser<ChessRogueQuitScRsp>(() => new ChessRogueQuitScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MODDIBHCPPDFieldNumber = 2;

	private CGDFGMMKJAH mODDIBHCPPD_;

	public const int RogueGetInfoFieldNumber = 3;

	private BABAGEDCCBG rogueGetInfo_;

	public const int NDMLEGLIOGNFieldNumber = 7;

	private FIILPHKLFEK nDMLEGLIOGN_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int StageInfoFieldNumber = 11;

	private EJCCHHAAGNH stageInfo_;

	public const int OCLLADBFKHPFieldNumber = 12;

	private PDAMBCFFPDI oCLLADBFKHP_;

	public const int IMPBELJGDJHFieldNumber = 15;

	private JMOGPMCJGLE iMPBELJGDJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueQuitScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueQuitScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGDFGMMKJAH MODDIBHCPPD
	{
		get
		{
			return mODDIBHCPPD_;
		}
		set
		{
			mODDIBHCPPD_ = value;
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
	public ChessRogueQuitScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueQuitScRsp(ChessRogueQuitScRsp other)
		: this()
	{
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
		nDMLEGLIOGN_ = ((other.nDMLEGLIOGN_ != null) ? other.nDMLEGLIOGN_.Clone() : null);
		retcode_ = other.retcode_;
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		oCLLADBFKHP_ = ((other.oCLLADBFKHP_ != null) ? other.oCLLADBFKHP_.Clone() : null);
		iMPBELJGDJH_ = ((other.iMPBELJGDJH_ != null) ? other.iMPBELJGDJH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueQuitScRsp Clone()
	{
		return new ChessRogueQuitScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueQuitScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueQuitScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
		{
			return false;
		}
		if (!object.Equals(RogueGetInfo, other.RogueGetInfo))
		{
			return false;
		}
		if (!object.Equals(NDMLEGLIOGN, other.NDMLEGLIOGN))
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
		if (!object.Equals(IMPBELJGDJH, other.IMPBELJGDJH))
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
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
		}
		if (rogueGetInfo_ != null)
		{
			num ^= RogueGetInfo.GetHashCode();
		}
		if (nDMLEGLIOGN_ != null)
		{
			num ^= NDMLEGLIOGN.GetHashCode();
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
		if (iMPBELJGDJH_ != null)
		{
			num ^= IMPBELJGDJH.GetHashCode();
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
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MODDIBHCPPD);
		}
		if (rogueGetInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RogueGetInfo);
		}
		if (nDMLEGLIOGN_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(NDMLEGLIOGN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
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
		if (iMPBELJGDJH_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(IMPBELJGDJH);
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
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (rogueGetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGetInfo);
		}
		if (nDMLEGLIOGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NDMLEGLIOGN);
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
		if (iMPBELJGDJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPBELJGDJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueQuitScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new CGDFGMMKJAH();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
		}
		if (other.rogueGetInfo_ != null)
		{
			if (rogueGetInfo_ == null)
			{
				RogueGetInfo = new BABAGEDCCBG();
			}
			RogueGetInfo.MergeFrom(other.RogueGetInfo);
		}
		if (other.nDMLEGLIOGN_ != null)
		{
			if (nDMLEGLIOGN_ == null)
			{
				NDMLEGLIOGN = new FIILPHKLFEK();
			}
			NDMLEGLIOGN.MergeFrom(other.NDMLEGLIOGN);
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
		if (other.iMPBELJGDJH_ != null)
		{
			if (iMPBELJGDJH_ == null)
			{
				IMPBELJGDJH = new JMOGPMCJGLE();
			}
			IMPBELJGDJH.MergeFrom(other.IMPBELJGDJH);
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
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new CGDFGMMKJAH();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			case 26u:
				if (rogueGetInfo_ == null)
				{
					RogueGetInfo = new BABAGEDCCBG();
				}
				input.ReadMessage(RogueGetInfo);
				break;
			case 58u:
				if (nDMLEGLIOGN_ == null)
				{
					NDMLEGLIOGN = new FIILPHKLFEK();
				}
				input.ReadMessage(NDMLEGLIOGN);
				break;
			case 72u:
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
			case 122u:
				if (iMPBELJGDJH_ == null)
				{
					IMPBELJGDJH = new JMOGPMCJGLE();
				}
				input.ReadMessage(IMPBELJGDJH);
				break;
			}
		}
	}
}
