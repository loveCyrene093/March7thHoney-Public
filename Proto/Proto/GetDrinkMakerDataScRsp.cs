using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetDrinkMakerDataScRsp : IMessage<GetDrinkMakerDataScRsp>, IMessage, IEquatable<GetDrinkMakerDataScRsp>, IDeepCloneable<GetDrinkMakerDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetDrinkMakerDataScRsp> _parser = new MessageParser<GetDrinkMakerDataScRsp>(() => new GetDrinkMakerDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DKGODNAMBHHFieldNumber = 1;

	private CIGKBDIGGOI dKGODNAMBHH_;

	public const int DOHLLMLDLMPFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dOHLLMLDLMP_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dOHLLMLDLMP_ = new RepeatedField<uint>();

	public const int EDBOHDJDJAAFieldNumber = 4;

	private uint eDBOHDJDJAA_;

	public const int FDNDKOJLICDFieldNumber = 5;

	private uint fDNDKOJLICD_;

	public const int KJNAJEOOBKAFieldNumber = 6;

	private uint kJNAJEOOBKA_;

	public const int NJHMNGHOGJPFieldNumber = 7;

	private static readonly FieldCodec<POHIEKPHMGH> _repeated_nJHMNGHOGJP_codec = FieldCodec.ForMessage(58u, POHIEKPHMGH.Parser);

	private readonly RepeatedField<POHIEKPHMGH> nJHMNGHOGJP_ = new RepeatedField<POHIEKPHMGH>();

	public const int LevelFieldNumber = 8;

	private uint level_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int ExpFieldNumber = 12;

	private uint exp_;

	public const int MGGEPANJPLPFieldNumber = 15;

	private uint mGGEPANJPLP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetDrinkMakerDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetDrinkMakerDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI DKGODNAMBHH
	{
		get
		{
			return dKGODNAMBHH_;
		}
		set
		{
			dKGODNAMBHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DOHLLMLDLMP => dOHLLMLDLMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDBOHDJDJAA
	{
		get
		{
			return eDBOHDJDJAA_;
		}
		set
		{
			eDBOHDJDJAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FDNDKOJLICD
	{
		get
		{
			return fDNDKOJLICD_;
		}
		set
		{
			fDNDKOJLICD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KJNAJEOOBKA
	{
		get
		{
			return kJNAJEOOBKA_;
		}
		set
		{
			kJNAJEOOBKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<POHIEKPHMGH> NJHMNGHOGJP => nJHMNGHOGJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
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
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGGEPANJPLP
	{
		get
		{
			return mGGEPANJPLP_;
		}
		set
		{
			mGGEPANJPLP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDrinkMakerDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDrinkMakerDataScRsp(GetDrinkMakerDataScRsp other)
		: this()
	{
		dKGODNAMBHH_ = ((other.dKGODNAMBHH_ != null) ? other.dKGODNAMBHH_.Clone() : null);
		dOHLLMLDLMP_ = other.dOHLLMLDLMP_.Clone();
		eDBOHDJDJAA_ = other.eDBOHDJDJAA_;
		fDNDKOJLICD_ = other.fDNDKOJLICD_;
		kJNAJEOOBKA_ = other.kJNAJEOOBKA_;
		nJHMNGHOGJP_ = other.nJHMNGHOGJP_.Clone();
		level_ = other.level_;
		retcode_ = other.retcode_;
		exp_ = other.exp_;
		mGGEPANJPLP_ = other.mGGEPANJPLP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDrinkMakerDataScRsp Clone()
	{
		return new GetDrinkMakerDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetDrinkMakerDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetDrinkMakerDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DKGODNAMBHH, other.DKGODNAMBHH))
		{
			return false;
		}
		if (!dOHLLMLDLMP_.Equals(other.dOHLLMLDLMP_))
		{
			return false;
		}
		if (EDBOHDJDJAA != other.EDBOHDJDJAA)
		{
			return false;
		}
		if (FDNDKOJLICD != other.FDNDKOJLICD)
		{
			return false;
		}
		if (KJNAJEOOBKA != other.KJNAJEOOBKA)
		{
			return false;
		}
		if (!nJHMNGHOGJP_.Equals(other.nJHMNGHOGJP_))
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (MGGEPANJPLP != other.MGGEPANJPLP)
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
		if (dKGODNAMBHH_ != null)
		{
			num ^= DKGODNAMBHH.GetHashCode();
		}
		num ^= dOHLLMLDLMP_.GetHashCode();
		if (EDBOHDJDJAA != 0)
		{
			num ^= EDBOHDJDJAA.GetHashCode();
		}
		if (FDNDKOJLICD != 0)
		{
			num ^= FDNDKOJLICD.GetHashCode();
		}
		if (KJNAJEOOBKA != 0)
		{
			num ^= KJNAJEOOBKA.GetHashCode();
		}
		num ^= nJHMNGHOGJP_.GetHashCode();
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (MGGEPANJPLP != 0)
		{
			num ^= MGGEPANJPLP.GetHashCode();
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
		if (dKGODNAMBHH_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DKGODNAMBHH);
		}
		dOHLLMLDLMP_.WriteTo(ref output, _repeated_dOHLLMLDLMP_codec);
		if (EDBOHDJDJAA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EDBOHDJDJAA);
		}
		if (FDNDKOJLICD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FDNDKOJLICD);
		}
		if (KJNAJEOOBKA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KJNAJEOOBKA);
		}
		nJHMNGHOGJP_.WriteTo(ref output, _repeated_nJHMNGHOGJP_codec);
		if (Level != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Level);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Exp);
		}
		if (MGGEPANJPLP != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MGGEPANJPLP);
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
		if (dKGODNAMBHH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DKGODNAMBHH);
		}
		num += dOHLLMLDLMP_.CalculateSize(_repeated_dOHLLMLDLMP_codec);
		if (EDBOHDJDJAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDBOHDJDJAA);
		}
		if (FDNDKOJLICD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FDNDKOJLICD);
		}
		if (KJNAJEOOBKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KJNAJEOOBKA);
		}
		num += nJHMNGHOGJP_.CalculateSize(_repeated_nJHMNGHOGJP_codec);
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (MGGEPANJPLP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGGEPANJPLP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetDrinkMakerDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dKGODNAMBHH_ != null)
		{
			if (dKGODNAMBHH_ == null)
			{
				DKGODNAMBHH = new CIGKBDIGGOI();
			}
			DKGODNAMBHH.MergeFrom(other.DKGODNAMBHH);
		}
		dOHLLMLDLMP_.Add(other.dOHLLMLDLMP_);
		if (other.EDBOHDJDJAA != 0)
		{
			EDBOHDJDJAA = other.EDBOHDJDJAA;
		}
		if (other.FDNDKOJLICD != 0)
		{
			FDNDKOJLICD = other.FDNDKOJLICD;
		}
		if (other.KJNAJEOOBKA != 0)
		{
			KJNAJEOOBKA = other.KJNAJEOOBKA;
		}
		nJHMNGHOGJP_.Add(other.nJHMNGHOGJP_);
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.Exp != 0)
		{
			Exp = other.Exp;
		}
		if (other.MGGEPANJPLP != 0)
		{
			MGGEPANJPLP = other.MGGEPANJPLP;
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
			case 10u:
				if (dKGODNAMBHH_ == null)
				{
					DKGODNAMBHH = new CIGKBDIGGOI();
				}
				input.ReadMessage(DKGODNAMBHH);
				break;
			case 24u:
			case 26u:
				dOHLLMLDLMP_.AddEntriesFrom(ref input, _repeated_dOHLLMLDLMP_codec);
				break;
			case 32u:
				EDBOHDJDJAA = input.ReadUInt32();
				break;
			case 40u:
				FDNDKOJLICD = input.ReadUInt32();
				break;
			case 48u:
				KJNAJEOOBKA = input.ReadUInt32();
				break;
			case 58u:
				nJHMNGHOGJP_.AddEntriesFrom(ref input, _repeated_nJHMNGHOGJP_codec);
				break;
			case 64u:
				Level = input.ReadUInt32();
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				Exp = input.ReadUInt32();
				break;
			case 120u:
				MGGEPANJPLP = input.ReadUInt32();
				break;
			}
		}
	}
}
