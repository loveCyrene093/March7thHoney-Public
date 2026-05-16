using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAetherDivideChallengeInfoScRsp : IMessage<GetAetherDivideChallengeInfoScRsp>, IMessage, IEquatable<GetAetherDivideChallengeInfoScRsp>, IDeepCloneable<GetAetherDivideChallengeInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAetherDivideChallengeInfoScRsp> _parser = new MessageParser<GetAetherDivideChallengeInfoScRsp>(() => new GetAetherDivideChallengeInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HPMHFDGMGGHFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_hPMHFDGMGGH_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> hPMHFDGMGGH_ = new RepeatedField<uint>();

	public const int JAGHEMPBMLDFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_jAGHEMPBMLD_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> jAGHEMPBMLD_ = new RepeatedField<uint>();

	public const int KAGCEADCKFJFieldNumber = 13;

	private uint kAGCEADCKFJ_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAetherDivideChallengeInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAetherDivideChallengeInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HPMHFDGMGGH => hPMHFDGMGGH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JAGHEMPBMLD => jAGHEMPBMLD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KAGCEADCKFJ
	{
		get
		{
			return kAGCEADCKFJ_;
		}
		set
		{
			kAGCEADCKFJ_ = value;
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
	public GetAetherDivideChallengeInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAetherDivideChallengeInfoScRsp(GetAetherDivideChallengeInfoScRsp other)
		: this()
	{
		hPMHFDGMGGH_ = other.hPMHFDGMGGH_.Clone();
		jAGHEMPBMLD_ = other.jAGHEMPBMLD_.Clone();
		kAGCEADCKFJ_ = other.kAGCEADCKFJ_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAetherDivideChallengeInfoScRsp Clone()
	{
		return new GetAetherDivideChallengeInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAetherDivideChallengeInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAetherDivideChallengeInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hPMHFDGMGGH_.Equals(other.hPMHFDGMGGH_))
		{
			return false;
		}
		if (!jAGHEMPBMLD_.Equals(other.jAGHEMPBMLD_))
		{
			return false;
		}
		if (KAGCEADCKFJ != other.KAGCEADCKFJ)
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
		num ^= hPMHFDGMGGH_.GetHashCode();
		num ^= jAGHEMPBMLD_.GetHashCode();
		if (KAGCEADCKFJ != 0)
		{
			num ^= KAGCEADCKFJ.GetHashCode();
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
		hPMHFDGMGGH_.WriteTo(ref output, _repeated_hPMHFDGMGGH_codec);
		jAGHEMPBMLD_.WriteTo(ref output, _repeated_jAGHEMPBMLD_codec);
		if (KAGCEADCKFJ != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(KAGCEADCKFJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		num += hPMHFDGMGGH_.CalculateSize(_repeated_hPMHFDGMGGH_codec);
		num += jAGHEMPBMLD_.CalculateSize(_repeated_jAGHEMPBMLD_codec);
		if (KAGCEADCKFJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KAGCEADCKFJ);
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
	public void MergeFrom(GetAetherDivideChallengeInfoScRsp other)
	{
		if (other != null)
		{
			hPMHFDGMGGH_.Add(other.hPMHFDGMGGH_);
			jAGHEMPBMLD_.Add(other.jAGHEMPBMLD_);
			if (other.KAGCEADCKFJ != 0)
			{
				KAGCEADCKFJ = other.KAGCEADCKFJ;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 18u:
				hPMHFDGMGGH_.AddEntriesFrom(ref input, _repeated_hPMHFDGMGGH_codec);
				break;
			case 80u:
			case 82u:
				jAGHEMPBMLD_.AddEntriesFrom(ref input, _repeated_jAGHEMPBMLD_codec);
				break;
			case 104u:
				KAGCEADCKFJ = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
