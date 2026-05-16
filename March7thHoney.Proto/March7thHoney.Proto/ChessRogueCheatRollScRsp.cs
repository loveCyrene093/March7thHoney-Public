using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueCheatRollScRsp : IMessage<ChessRogueCheatRollScRsp>, IMessage, IEquatable<ChessRogueCheatRollScRsp>, IDeepCloneable<ChessRogueCheatRollScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueCheatRollScRsp> _parser = new MessageParser<ChessRogueCheatRollScRsp>(() => new ChessRogueCheatRollScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int PJABKDBFPIMFieldNumber = 3;

	private DFAOIALEBOH pJABKDBFPIM_;

	public const int CCOGFKLOFKLFieldNumber = 8;

	private uint cCOGFKLOFKL_;

	public const int OEFFFDCFAFCFieldNumber = 13;

	private uint oEFFFDCFAFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueCheatRollScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueCheatRollScRspReflection.Descriptor.MessageTypes[0];

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
	public DFAOIALEBOH PJABKDBFPIM
	{
		get
		{
			return pJABKDBFPIM_;
		}
		set
		{
			pJABKDBFPIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CCOGFKLOFKL
	{
		get
		{
			return cCOGFKLOFKL_;
		}
		set
		{
			cCOGFKLOFKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OEFFFDCFAFC
	{
		get
		{
			return oEFFFDCFAFC_;
		}
		set
		{
			oEFFFDCFAFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCheatRollScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCheatRollScRsp(ChessRogueCheatRollScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		pJABKDBFPIM_ = ((other.pJABKDBFPIM_ != null) ? other.pJABKDBFPIM_.Clone() : null);
		cCOGFKLOFKL_ = other.cCOGFKLOFKL_;
		oEFFFDCFAFC_ = other.oEFFFDCFAFC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCheatRollScRsp Clone()
	{
		return new ChessRogueCheatRollScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueCheatRollScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueCheatRollScRsp other)
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
		if (!object.Equals(PJABKDBFPIM, other.PJABKDBFPIM))
		{
			return false;
		}
		if (CCOGFKLOFKL != other.CCOGFKLOFKL)
		{
			return false;
		}
		if (OEFFFDCFAFC != other.OEFFFDCFAFC)
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
		if (pJABKDBFPIM_ != null)
		{
			num ^= PJABKDBFPIM.GetHashCode();
		}
		if (CCOGFKLOFKL != 0)
		{
			num ^= CCOGFKLOFKL.GetHashCode();
		}
		if (OEFFFDCFAFC != 0)
		{
			num ^= OEFFFDCFAFC.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (pJABKDBFPIM_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PJABKDBFPIM);
		}
		if (CCOGFKLOFKL != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CCOGFKLOFKL);
		}
		if (OEFFFDCFAFC != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(OEFFFDCFAFC);
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
		if (pJABKDBFPIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJABKDBFPIM);
		}
		if (CCOGFKLOFKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CCOGFKLOFKL);
		}
		if (OEFFFDCFAFC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OEFFFDCFAFC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueCheatRollScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.pJABKDBFPIM_ != null)
		{
			if (pJABKDBFPIM_ == null)
			{
				PJABKDBFPIM = new DFAOIALEBOH();
			}
			PJABKDBFPIM.MergeFrom(other.PJABKDBFPIM);
		}
		if (other.CCOGFKLOFKL != 0)
		{
			CCOGFKLOFKL = other.CCOGFKLOFKL;
		}
		if (other.OEFFFDCFAFC != 0)
		{
			OEFFFDCFAFC = other.OEFFFDCFAFC;
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				if (pJABKDBFPIM_ == null)
				{
					PJABKDBFPIM = new DFAOIALEBOH();
				}
				input.ReadMessage(PJABKDBFPIM);
				break;
			case 64u:
				CCOGFKLOFKL = input.ReadUInt32();
				break;
			case 104u:
				OEFFFDCFAFC = input.ReadUInt32();
				break;
			}
		}
	}
}
