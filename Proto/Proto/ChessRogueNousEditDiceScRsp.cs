using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueNousEditDiceScRsp : IMessage<ChessRogueNousEditDiceScRsp>, IMessage, IEquatable<ChessRogueNousEditDiceScRsp>, IDeepCloneable<ChessRogueNousEditDiceScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueNousEditDiceScRsp> _parser = new MessageParser<ChessRogueNousEditDiceScRsp>(() => new ChessRogueNousEditDiceScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int BDJDBMICKKPFieldNumber = 15;

	private GLENEKHDKLJ bDJDBMICKKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueNousEditDiceScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueNousEditDiceScRspReflection.Descriptor.MessageTypes[0];

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
	public GLENEKHDKLJ BDJDBMICKKP
	{
		get
		{
			return bDJDBMICKKP_;
		}
		set
		{
			bDJDBMICKKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousEditDiceScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousEditDiceScRsp(ChessRogueNousEditDiceScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		bDJDBMICKKP_ = ((other.bDJDBMICKKP_ != null) ? other.bDJDBMICKKP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousEditDiceScRsp Clone()
	{
		return new ChessRogueNousEditDiceScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueNousEditDiceScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueNousEditDiceScRsp other)
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
		if (!object.Equals(BDJDBMICKKP, other.BDJDBMICKKP))
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
		if (bDJDBMICKKP_ != null)
		{
			num ^= BDJDBMICKKP.GetHashCode();
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
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (bDJDBMICKKP_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(BDJDBMICKKP);
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
		if (bDJDBMICKKP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BDJDBMICKKP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueNousEditDiceScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.bDJDBMICKKP_ != null)
		{
			if (bDJDBMICKKP_ == null)
			{
				BDJDBMICKKP = new GLENEKHDKLJ();
			}
			BDJDBMICKKP.MergeFrom(other.BDJDBMICKKP);
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
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				if (bDJDBMICKKP_ == null)
				{
					BDJDBMICKKP = new GLENEKHDKLJ();
				}
				input.ReadMessage(BDJDBMICKKP);
				break;
			}
		}
	}
}
