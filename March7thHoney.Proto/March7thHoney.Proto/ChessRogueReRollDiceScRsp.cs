using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueReRollDiceScRsp : IMessage<ChessRogueReRollDiceScRsp>, IMessage, IEquatable<ChessRogueReRollDiceScRsp>, IDeepCloneable<ChessRogueReRollDiceScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueReRollDiceScRsp> _parser = new MessageParser<ChessRogueReRollDiceScRsp>(() => new ChessRogueReRollDiceScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int PJABKDBFPIMFieldNumber = 11;

	private DFAOIALEBOH pJABKDBFPIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueReRollDiceScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueReRollDiceScRspReflection.Descriptor.MessageTypes[0];

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
	public ChessRogueReRollDiceScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueReRollDiceScRsp(ChessRogueReRollDiceScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		pJABKDBFPIM_ = ((other.pJABKDBFPIM_ != null) ? other.pJABKDBFPIM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueReRollDiceScRsp Clone()
	{
		return new ChessRogueReRollDiceScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueReRollDiceScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueReRollDiceScRsp other)
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
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (pJABKDBFPIM_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(PJABKDBFPIM);
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueReRollDiceScRsp other)
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
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (pJABKDBFPIM_ == null)
				{
					PJABKDBFPIM = new DFAOIALEBOH();
				}
				input.ReadMessage(PJABKDBFPIM);
				break;
			}
		}
	}
}
