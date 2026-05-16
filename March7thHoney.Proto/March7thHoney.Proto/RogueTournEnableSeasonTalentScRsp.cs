using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournEnableSeasonTalentScRsp : IMessage<RogueTournEnableSeasonTalentScRsp>, IMessage, IEquatable<RogueTournEnableSeasonTalentScRsp>, IDeepCloneable<RogueTournEnableSeasonTalentScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournEnableSeasonTalentScRsp> _parser = new MessageParser<RogueTournEnableSeasonTalentScRsp>(() => new RogueTournEnableSeasonTalentScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BNAJPPKFFBDFieldNumber = 7;

	private HLGALKACKLJ bNAJPPKFFBD_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournEnableSeasonTalentScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournEnableSeasonTalentScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLGALKACKLJ BNAJPPKFFBD
	{
		get
		{
			return bNAJPPKFFBD_;
		}
		set
		{
			bNAJPPKFFBD_ = value;
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
	public RogueTournEnableSeasonTalentScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnableSeasonTalentScRsp(RogueTournEnableSeasonTalentScRsp other)
		: this()
	{
		bNAJPPKFFBD_ = ((other.bNAJPPKFFBD_ != null) ? other.bNAJPPKFFBD_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnableSeasonTalentScRsp Clone()
	{
		return new RogueTournEnableSeasonTalentScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournEnableSeasonTalentScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournEnableSeasonTalentScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BNAJPPKFFBD, other.BNAJPPKFFBD))
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
		if (bNAJPPKFFBD_ != null)
		{
			num ^= BNAJPPKFFBD.GetHashCode();
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
		if (bNAJPPKFFBD_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(BNAJPPKFFBD);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
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
		if (bNAJPPKFFBD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNAJPPKFFBD);
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
	public void MergeFrom(RogueTournEnableSeasonTalentScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bNAJPPKFFBD_ != null)
		{
			if (bNAJPPKFFBD_ == null)
			{
				BNAJPPKFFBD = new HLGALKACKLJ();
			}
			BNAJPPKFFBD.MergeFrom(other.BNAJPPKFFBD);
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
				if (bNAJPPKFFBD_ == null)
				{
					BNAJPPKFFBD = new HLGALKACKLJ();
				}
				input.ReadMessage(BNAJPPKFFBD);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
