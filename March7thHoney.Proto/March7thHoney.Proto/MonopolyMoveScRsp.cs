using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyMoveScRsp : IMessage<MonopolyMoveScRsp>, IMessage, IEquatable<MonopolyMoveScRsp>, IDeepCloneable<MonopolyMoveScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyMoveScRsp> _parser = new MessageParser<MonopolyMoveScRsp>(() => new MonopolyMoveScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LKOIHHMBHOFFieldNumber = 11;

	private static readonly FieldCodec<AAHBECICOEN> _repeated_lKOIHHMBHOF_codec = FieldCodec.ForMessage(90u, AAHBECICOEN.Parser);

	private readonly RepeatedField<AAHBECICOEN> lKOIHHMBHOF_ = new RepeatedField<AAHBECICOEN>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int AMMJECHPGPEFieldNumber = 15;

	private IMDPAIOOHMF aMMJECHPGPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyMoveScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyMoveScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AAHBECICOEN> LKOIHHMBHOF => lKOIHHMBHOF_;

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
	public IMDPAIOOHMF AMMJECHPGPE
	{
		get
		{
			return aMMJECHPGPE_;
		}
		set
		{
			aMMJECHPGPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyMoveScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyMoveScRsp(MonopolyMoveScRsp other)
		: this()
	{
		lKOIHHMBHOF_ = other.lKOIHHMBHOF_.Clone();
		retcode_ = other.retcode_;
		aMMJECHPGPE_ = ((other.aMMJECHPGPE_ != null) ? other.aMMJECHPGPE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyMoveScRsp Clone()
	{
		return new MonopolyMoveScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyMoveScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyMoveScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lKOIHHMBHOF_.Equals(other.lKOIHHMBHOF_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(AMMJECHPGPE, other.AMMJECHPGPE))
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
		num ^= lKOIHHMBHOF_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (aMMJECHPGPE_ != null)
		{
			num ^= AMMJECHPGPE.GetHashCode();
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
		lKOIHHMBHOF_.WriteTo(ref output, _repeated_lKOIHHMBHOF_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (aMMJECHPGPE_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(AMMJECHPGPE);
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
		num += lKOIHHMBHOF_.CalculateSize(_repeated_lKOIHHMBHOF_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (aMMJECHPGPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AMMJECHPGPE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyMoveScRsp other)
	{
		if (other == null)
		{
			return;
		}
		lKOIHHMBHOF_.Add(other.lKOIHHMBHOF_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.aMMJECHPGPE_ != null)
		{
			if (aMMJECHPGPE_ == null)
			{
				AMMJECHPGPE = new IMDPAIOOHMF();
			}
			AMMJECHPGPE.MergeFrom(other.AMMJECHPGPE);
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
			case 90u:
				lKOIHHMBHOF_.AddEntriesFrom(ref input, _repeated_lKOIHHMBHOF_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				if (aMMJECHPGPE_ == null)
				{
					AMMJECHPGPE = new IMDPAIOOHMF();
				}
				input.ReadMessage(AMMJECHPGPE);
				break;
			}
		}
	}
}
