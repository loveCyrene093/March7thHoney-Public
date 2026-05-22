using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueQueryScRsp : IMessage<ChessRogueQueryScRsp>, IMessage, IEquatable<ChessRogueQueryScRsp>, IDeepCloneable<ChessRogueQueryScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueQueryScRsp> _parser = new MessageParser<ChessRogueQueryScRsp>(() => new ChessRogueQueryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RogueGetInfoFieldNumber = 2;

	private BABAGEDCCBG rogueGetInfo_;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int NDMLEGLIOGNFieldNumber = 5;

	private FIILPHKLFEK nDMLEGLIOGN_;

	public const int OCLLADBFKHPFieldNumber = 6;

	private PDAMBCFFPDI oCLLADBFKHP_;

	public const int LJMFGDFBLCKFieldNumber = 7;

	private ILEJGEDBEKF lJMFGDFBLCK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueQueryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueQueryScRspReflection.Descriptor.MessageTypes[0];

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
	public ILEJGEDBEKF LJMFGDFBLCK
	{
		get
		{
			return lJMFGDFBLCK_;
		}
		set
		{
			lJMFGDFBLCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueQueryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueQueryScRsp(ChessRogueQueryScRsp other)
		: this()
	{
		rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
		retcode_ = other.retcode_;
		nDMLEGLIOGN_ = ((other.nDMLEGLIOGN_ != null) ? other.nDMLEGLIOGN_.Clone() : null);
		oCLLADBFKHP_ = ((other.oCLLADBFKHP_ != null) ? other.oCLLADBFKHP_.Clone() : null);
		lJMFGDFBLCK_ = ((other.lJMFGDFBLCK_ != null) ? other.lJMFGDFBLCK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueQueryScRsp Clone()
	{
		return new ChessRogueQueryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueQueryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueQueryScRsp other)
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
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(NDMLEGLIOGN, other.NDMLEGLIOGN))
		{
			return false;
		}
		if (!object.Equals(OCLLADBFKHP, other.OCLLADBFKHP))
		{
			return false;
		}
		if (!object.Equals(LJMFGDFBLCK, other.LJMFGDFBLCK))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (nDMLEGLIOGN_ != null)
		{
			num ^= NDMLEGLIOGN.GetHashCode();
		}
		if (oCLLADBFKHP_ != null)
		{
			num ^= OCLLADBFKHP.GetHashCode();
		}
		if (lJMFGDFBLCK_ != null)
		{
			num ^= LJMFGDFBLCK.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (nDMLEGLIOGN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NDMLEGLIOGN);
		}
		if (oCLLADBFKHP_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OCLLADBFKHP);
		}
		if (lJMFGDFBLCK_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(LJMFGDFBLCK);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (nDMLEGLIOGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NDMLEGLIOGN);
		}
		if (oCLLADBFKHP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OCLLADBFKHP);
		}
		if (lJMFGDFBLCK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJMFGDFBLCK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueQueryScRsp other)
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
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
		if (other.lJMFGDFBLCK_ != null)
		{
			if (lJMFGDFBLCK_ == null)
			{
				LJMFGDFBLCK = new ILEJGEDBEKF();
			}
			LJMFGDFBLCK.MergeFrom(other.LJMFGDFBLCK);
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 42u:
				if (nDMLEGLIOGN_ == null)
				{
					NDMLEGLIOGN = new FIILPHKLFEK();
				}
				input.ReadMessage(NDMLEGLIOGN);
				break;
			case 50u:
				if (oCLLADBFKHP_ == null)
				{
					OCLLADBFKHP = new PDAMBCFFPDI();
				}
				input.ReadMessage(OCLLADBFKHP);
				break;
			case 58u:
				if (lJMFGDFBLCK_ == null)
				{
					LJMFGDFBLCK = new ILEJGEDBEKF();
				}
				input.ReadMessage(LJMFGDFBLCK);
				break;
			}
		}
	}
}
