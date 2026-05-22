using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGetRafflePoolInfoScRsp : IMessage<MonopolyGetRafflePoolInfoScRsp>, IMessage, IEquatable<MonopolyGetRafflePoolInfoScRsp>, IDeepCloneable<MonopolyGetRafflePoolInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGetRafflePoolInfoScRsp> _parser = new MessageParser<MonopolyGetRafflePoolInfoScRsp>(() => new MonopolyGetRafflePoolInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int FBACKLDDEBLFieldNumber = 15;

	private JLLHMAHMCBF fBACKLDDEBL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGetRafflePoolInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGetRafflePoolInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public JLLHMAHMCBF FBACKLDDEBL
	{
		get
		{
			return fBACKLDDEBL_;
		}
		set
		{
			fBACKLDDEBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRafflePoolInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRafflePoolInfoScRsp(MonopolyGetRafflePoolInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		fBACKLDDEBL_ = ((other.fBACKLDDEBL_ != null) ? other.fBACKLDDEBL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRafflePoolInfoScRsp Clone()
	{
		return new MonopolyGetRafflePoolInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGetRafflePoolInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGetRafflePoolInfoScRsp other)
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
		if (!object.Equals(FBACKLDDEBL, other.FBACKLDDEBL))
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
		if (fBACKLDDEBL_ != null)
		{
			num ^= FBACKLDDEBL.GetHashCode();
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
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (fBACKLDDEBL_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(FBACKLDDEBL);
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
		if (fBACKLDDEBL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FBACKLDDEBL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyGetRafflePoolInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.fBACKLDDEBL_ != null)
		{
			if (fBACKLDDEBL_ == null)
			{
				FBACKLDDEBL = new JLLHMAHMCBF();
			}
			FBACKLDDEBL.MergeFrom(other.FBACKLDDEBL);
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
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				if (fBACKLDDEBL_ == null)
				{
					FBACKLDDEBL = new JLLHMAHMCBF();
				}
				input.ReadMessage(FBACKLDDEBL);
				break;
			}
		}
	}
}
