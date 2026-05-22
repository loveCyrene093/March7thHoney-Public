using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGameBingoFlipCardScRsp : IMessage<MonopolyGameBingoFlipCardScRsp>, IMessage, IEquatable<MonopolyGameBingoFlipCardScRsp>, IDeepCloneable<MonopolyGameBingoFlipCardScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGameBingoFlipCardScRsp> _parser = new MessageParser<MonopolyGameBingoFlipCardScRsp>(() => new MonopolyGameBingoFlipCardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JKLFMOHICMOFieldNumber = 2;

	private bool jKLFMOHICMO_;

	public const int EAOFJFAFAHOFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_eAOFJFAFAHO_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> eAOFJFAFAHO_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int EPLBCNFMLILFieldNumber = 14;

	private uint ePLBCNFMLIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGameBingoFlipCardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGameBingoFlipCardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JKLFMOHICMO
	{
		get
		{
			return jKLFMOHICMO_;
		}
		set
		{
			jKLFMOHICMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EAOFJFAFAHO => eAOFJFAFAHO_;

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
	public uint EPLBCNFMLIL
	{
		get
		{
			return ePLBCNFMLIL_;
		}
		set
		{
			ePLBCNFMLIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameBingoFlipCardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameBingoFlipCardScRsp(MonopolyGameBingoFlipCardScRsp other)
		: this()
	{
		jKLFMOHICMO_ = other.jKLFMOHICMO_;
		eAOFJFAFAHO_ = other.eAOFJFAFAHO_.Clone();
		retcode_ = other.retcode_;
		ePLBCNFMLIL_ = other.ePLBCNFMLIL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameBingoFlipCardScRsp Clone()
	{
		return new MonopolyGameBingoFlipCardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGameBingoFlipCardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGameBingoFlipCardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JKLFMOHICMO != other.JKLFMOHICMO)
		{
			return false;
		}
		if (!eAOFJFAFAHO_.Equals(other.eAOFJFAFAHO_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EPLBCNFMLIL != other.EPLBCNFMLIL)
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
		if (JKLFMOHICMO)
		{
			num ^= JKLFMOHICMO.GetHashCode();
		}
		num ^= eAOFJFAFAHO_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EPLBCNFMLIL != 0)
		{
			num ^= EPLBCNFMLIL.GetHashCode();
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
		if (JKLFMOHICMO)
		{
			output.WriteRawTag(16);
			output.WriteBool(JKLFMOHICMO);
		}
		eAOFJFAFAHO_.WriteTo(ref output, _repeated_eAOFJFAFAHO_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (EPLBCNFMLIL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(EPLBCNFMLIL);
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
		if (JKLFMOHICMO)
		{
			num += 2;
		}
		num += eAOFJFAFAHO_.CalculateSize(_repeated_eAOFJFAFAHO_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EPLBCNFMLIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPLBCNFMLIL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyGameBingoFlipCardScRsp other)
	{
		if (other != null)
		{
			if (other.JKLFMOHICMO)
			{
				JKLFMOHICMO = other.JKLFMOHICMO;
			}
			eAOFJFAFAHO_.Add(other.eAOFJFAFAHO_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EPLBCNFMLIL != 0)
			{
				EPLBCNFMLIL = other.EPLBCNFMLIL;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 16u:
				JKLFMOHICMO = input.ReadBool();
				break;
			case 24u:
			case 26u:
				eAOFJFAFAHO_.AddEntriesFrom(ref input, _repeated_eAOFJFAFAHO_codec);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				EPLBCNFMLIL = input.ReadUInt32();
				break;
			}
		}
	}
}
