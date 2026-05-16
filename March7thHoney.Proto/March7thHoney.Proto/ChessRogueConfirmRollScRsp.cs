using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueConfirmRollScRsp : IMessage<ChessRogueConfirmRollScRsp>, IMessage, IEquatable<ChessRogueConfirmRollScRsp>, IDeepCloneable<ChessRogueConfirmRollScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueConfirmRollScRsp> _parser = new MessageParser<ChessRogueConfirmRollScRsp>(() => new ChessRogueConfirmRollScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PJABKDBFPIMFieldNumber = 7;

	private DFAOIALEBOH pJABKDBFPIM_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueConfirmRollScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueConfirmRollScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public ChessRogueConfirmRollScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueConfirmRollScRsp(ChessRogueConfirmRollScRsp other)
		: this()
	{
		pJABKDBFPIM_ = ((other.pJABKDBFPIM_ != null) ? other.pJABKDBFPIM_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueConfirmRollScRsp Clone()
	{
		return new ChessRogueConfirmRollScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueConfirmRollScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueConfirmRollScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PJABKDBFPIM, other.PJABKDBFPIM))
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
		if (pJABKDBFPIM_ != null)
		{
			num ^= PJABKDBFPIM.GetHashCode();
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
		if (pJABKDBFPIM_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(PJABKDBFPIM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
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
		if (pJABKDBFPIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJABKDBFPIM);
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
	public void MergeFrom(ChessRogueConfirmRollScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pJABKDBFPIM_ != null)
		{
			if (pJABKDBFPIM_ == null)
			{
				PJABKDBFPIM = new DFAOIALEBOH();
			}
			PJABKDBFPIM.MergeFrom(other.PJABKDBFPIM);
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
			case 58u:
				if (pJABKDBFPIM_ == null)
				{
					PJABKDBFPIM = new DFAOIALEBOH();
				}
				input.ReadMessage(PJABKDBFPIM);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
