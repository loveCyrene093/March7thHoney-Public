using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooDataScRsp : IMessage<SpaceZooDataScRsp>, IMessage, IEquatable<SpaceZooDataScRsp>, IDeepCloneable<SpaceZooDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooDataScRsp> _parser = new MessageParser<SpaceZooDataScRsp>(() => new SpaceZooDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int NOJFAFFNBEDFieldNumber = 7;

	private static readonly FieldCodec<DMNDJBPGEKG> _repeated_nOJFAFFNBED_codec = FieldCodec.ForMessage(58u, DMNDJBPGEKG.Parser);

	private readonly RepeatedField<DMNDJBPGEKG> nOJFAFFNBED_ = new RepeatedField<DMNDJBPGEKG>();

	public const int NOAGECCEEKNFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_nOAGECCEEKN_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> nOAGECCEEKN_ = new RepeatedField<uint>();

	public const int HLCJEFOJAHKFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_hLCJEFOJAHK_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> hLCJEFOJAHK_ = new RepeatedField<uint>();

	public const int EFOCFECKNKJFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_eFOCFECKNKJ_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> eFOCFECKNKJ_ = new RepeatedField<uint>();

	public const int MDAMGMKLLKEFieldNumber = 12;

	private uint mDAMGMKLLKE_;

	public const int DKECFINBDNKFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_dKECFINBDNK_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> dKECFINBDNK_ = new RepeatedField<uint>();

	public const int JKLGAPGHBHPFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_jKLGAPGHBHP_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> jKLGAPGHBHP_ = new RepeatedField<uint>();

	public const int DNIGGEEFBFNFieldNumber = 15;

	private static readonly FieldCodec<LKJMLPJEPGG> _repeated_dNIGGEEFBFN_codec = FieldCodec.ForMessage(122u, LKJMLPJEPGG.Parser);

	private readonly RepeatedField<LKJMLPJEPGG> dNIGGEEFBFN_ = new RepeatedField<LKJMLPJEPGG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooDataScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<DMNDJBPGEKG> NOJFAFFNBED => nOJFAFFNBED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NOAGECCEEKN => nOAGECCEEKN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HLCJEFOJAHK => hLCJEFOJAHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EFOCFECKNKJ => eFOCFECKNKJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MDAMGMKLLKE
	{
		get
		{
			return mDAMGMKLLKE_;
		}
		set
		{
			mDAMGMKLLKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DKECFINBDNK => dKECFINBDNK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JKLGAPGHBHP => jKLGAPGHBHP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LKJMLPJEPGG> DNIGGEEFBFN => dNIGGEEFBFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooDataScRsp(SpaceZooDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		nOJFAFFNBED_ = other.nOJFAFFNBED_.Clone();
		nOAGECCEEKN_ = other.nOAGECCEEKN_.Clone();
		hLCJEFOJAHK_ = other.hLCJEFOJAHK_.Clone();
		eFOCFECKNKJ_ = other.eFOCFECKNKJ_.Clone();
		mDAMGMKLLKE_ = other.mDAMGMKLLKE_;
		dKECFINBDNK_ = other.dKECFINBDNK_.Clone();
		jKLGAPGHBHP_ = other.jKLGAPGHBHP_.Clone();
		dNIGGEEFBFN_ = other.dNIGGEEFBFN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooDataScRsp Clone()
	{
		return new SpaceZooDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooDataScRsp other)
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
		if (!nOJFAFFNBED_.Equals(other.nOJFAFFNBED_))
		{
			return false;
		}
		if (!nOAGECCEEKN_.Equals(other.nOAGECCEEKN_))
		{
			return false;
		}
		if (!hLCJEFOJAHK_.Equals(other.hLCJEFOJAHK_))
		{
			return false;
		}
		if (!eFOCFECKNKJ_.Equals(other.eFOCFECKNKJ_))
		{
			return false;
		}
		if (MDAMGMKLLKE != other.MDAMGMKLLKE)
		{
			return false;
		}
		if (!dKECFINBDNK_.Equals(other.dKECFINBDNK_))
		{
			return false;
		}
		if (!jKLGAPGHBHP_.Equals(other.jKLGAPGHBHP_))
		{
			return false;
		}
		if (!dNIGGEEFBFN_.Equals(other.dNIGGEEFBFN_))
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
		num ^= nOJFAFFNBED_.GetHashCode();
		num ^= nOAGECCEEKN_.GetHashCode();
		num ^= hLCJEFOJAHK_.GetHashCode();
		num ^= eFOCFECKNKJ_.GetHashCode();
		if (MDAMGMKLLKE != 0)
		{
			num ^= MDAMGMKLLKE.GetHashCode();
		}
		num ^= dKECFINBDNK_.GetHashCode();
		num ^= jKLGAPGHBHP_.GetHashCode();
		num ^= dNIGGEEFBFN_.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		nOJFAFFNBED_.WriteTo(ref output, _repeated_nOJFAFFNBED_codec);
		nOAGECCEEKN_.WriteTo(ref output, _repeated_nOAGECCEEKN_codec);
		hLCJEFOJAHK_.WriteTo(ref output, _repeated_hLCJEFOJAHK_codec);
		eFOCFECKNKJ_.WriteTo(ref output, _repeated_eFOCFECKNKJ_codec);
		if (MDAMGMKLLKE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MDAMGMKLLKE);
		}
		dKECFINBDNK_.WriteTo(ref output, _repeated_dKECFINBDNK_codec);
		jKLGAPGHBHP_.WriteTo(ref output, _repeated_jKLGAPGHBHP_codec);
		dNIGGEEFBFN_.WriteTo(ref output, _repeated_dNIGGEEFBFN_codec);
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
		num += nOJFAFFNBED_.CalculateSize(_repeated_nOJFAFFNBED_codec);
		num += nOAGECCEEKN_.CalculateSize(_repeated_nOAGECCEEKN_codec);
		num += hLCJEFOJAHK_.CalculateSize(_repeated_hLCJEFOJAHK_codec);
		num += eFOCFECKNKJ_.CalculateSize(_repeated_eFOCFECKNKJ_codec);
		if (MDAMGMKLLKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MDAMGMKLLKE);
		}
		num += dKECFINBDNK_.CalculateSize(_repeated_dKECFINBDNK_codec);
		num += jKLGAPGHBHP_.CalculateSize(_repeated_jKLGAPGHBHP_codec);
		num += dNIGGEEFBFN_.CalculateSize(_repeated_dNIGGEEFBFN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			nOJFAFFNBED_.Add(other.nOJFAFFNBED_);
			nOAGECCEEKN_.Add(other.nOAGECCEEKN_);
			hLCJEFOJAHK_.Add(other.hLCJEFOJAHK_);
			eFOCFECKNKJ_.Add(other.eFOCFECKNKJ_);
			if (other.MDAMGMKLLKE != 0)
			{
				MDAMGMKLLKE = other.MDAMGMKLLKE;
			}
			dKECFINBDNK_.Add(other.dKECFINBDNK_);
			jKLGAPGHBHP_.Add(other.jKLGAPGHBHP_);
			dNIGGEEFBFN_.Add(other.dNIGGEEFBFN_);
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
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 58u:
				nOJFAFFNBED_.AddEntriesFrom(ref input, _repeated_nOJFAFFNBED_codec);
				break;
			case 64u:
			case 66u:
				nOAGECCEEKN_.AddEntriesFrom(ref input, _repeated_nOAGECCEEKN_codec);
				break;
			case 80u:
			case 82u:
				hLCJEFOJAHK_.AddEntriesFrom(ref input, _repeated_hLCJEFOJAHK_codec);
				break;
			case 88u:
			case 90u:
				eFOCFECKNKJ_.AddEntriesFrom(ref input, _repeated_eFOCFECKNKJ_codec);
				break;
			case 96u:
				MDAMGMKLLKE = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				dKECFINBDNK_.AddEntriesFrom(ref input, _repeated_dKECFINBDNK_codec);
				break;
			case 112u:
			case 114u:
				jKLGAPGHBHP_.AddEntriesFrom(ref input, _repeated_jKLGAPGHBHP_codec);
				break;
			case 122u:
				dNIGGEEFBFN_.AddEntriesFrom(ref input, _repeated_dNIGGEEFBFN_codec);
				break;
			}
		}
	}
}
