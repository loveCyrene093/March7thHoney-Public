using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PBPIOFGODHC : IMessage<PBPIOFGODHC>, IMessage, IEquatable<PBPIOFGODHC>, IDeepCloneable<PBPIOFGODHC>, IBufferMessage
{
	private static readonly MessageParser<PBPIOFGODHC> _parser = new MessageParser<PBPIOFGODHC>(() => new PBPIOFGODHC());

	private UnknownFieldSet _unknownFields;

	public const int DICEPCGFBNOFieldNumber = 4;

	private uint dICEPCGFBNO_;

	public const int MMFJGLOFLKLFieldNumber = 9;

	private static readonly FieldCodec<CNABGOPKNJD> _repeated_mMFJGLOFLKL_codec = FieldCodec.ForMessage(74u, CNABGOPKNJD.Parser);

	private readonly RepeatedField<CNABGOPKNJD> mMFJGLOFLKL_ = new RepeatedField<CNABGOPKNJD>();

	public const int HBCJPCMJPHEFieldNumber = 13;

	private uint hBCJPCMJPHE_;

	public const int MOJBHKCPLDMFieldNumber = 14;

	private HADIBEMFDML mOJBHKCPLDM_;

	public const int MPNCPNILLJHFieldNumber = 15;

	private DKHAPDHBIFC mPNCPNILLJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PBPIOFGODHC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PBPIOFGODHCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DICEPCGFBNO
	{
		get
		{
			return dICEPCGFBNO_;
		}
		set
		{
			dICEPCGFBNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CNABGOPKNJD> MMFJGLOFLKL => mMFJGLOFLKL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBCJPCMJPHE
	{
		get
		{
			return hBCJPCMJPHE_;
		}
		set
		{
			hBCJPCMJPHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HADIBEMFDML MOJBHKCPLDM
	{
		get
		{
			return mOJBHKCPLDM_;
		}
		set
		{
			mOJBHKCPLDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKHAPDHBIFC MPNCPNILLJH
	{
		get
		{
			return mPNCPNILLJH_;
		}
		set
		{
			mPNCPNILLJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBPIOFGODHC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBPIOFGODHC(PBPIOFGODHC other)
		: this()
	{
		dICEPCGFBNO_ = other.dICEPCGFBNO_;
		mMFJGLOFLKL_ = other.mMFJGLOFLKL_.Clone();
		hBCJPCMJPHE_ = other.hBCJPCMJPHE_;
		mOJBHKCPLDM_ = other.mOJBHKCPLDM_;
		mPNCPNILLJH_ = other.mPNCPNILLJH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBPIOFGODHC Clone()
	{
		return new PBPIOFGODHC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PBPIOFGODHC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PBPIOFGODHC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DICEPCGFBNO != other.DICEPCGFBNO)
		{
			return false;
		}
		if (!mMFJGLOFLKL_.Equals(other.mMFJGLOFLKL_))
		{
			return false;
		}
		if (HBCJPCMJPHE != other.HBCJPCMJPHE)
		{
			return false;
		}
		if (MOJBHKCPLDM != other.MOJBHKCPLDM)
		{
			return false;
		}
		if (MPNCPNILLJH != other.MPNCPNILLJH)
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
		if (DICEPCGFBNO != 0)
		{
			num ^= DICEPCGFBNO.GetHashCode();
		}
		num ^= mMFJGLOFLKL_.GetHashCode();
		if (HBCJPCMJPHE != 0)
		{
			num ^= HBCJPCMJPHE.GetHashCode();
		}
		if (MOJBHKCPLDM != HADIBEMFDML.Imkmpbmamdg)
		{
			num ^= MOJBHKCPLDM.GetHashCode();
		}
		if (MPNCPNILLJH != DKHAPDHBIFC.Ijappfeelpa)
		{
			num ^= MPNCPNILLJH.GetHashCode();
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
		if (DICEPCGFBNO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DICEPCGFBNO);
		}
		mMFJGLOFLKL_.WriteTo(ref output, _repeated_mMFJGLOFLKL_codec);
		if (HBCJPCMJPHE != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HBCJPCMJPHE);
		}
		if (MOJBHKCPLDM != HADIBEMFDML.Imkmpbmamdg)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)MOJBHKCPLDM);
		}
		if (MPNCPNILLJH != DKHAPDHBIFC.Ijappfeelpa)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)MPNCPNILLJH);
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
		if (DICEPCGFBNO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DICEPCGFBNO);
		}
		num += mMFJGLOFLKL_.CalculateSize(_repeated_mMFJGLOFLKL_codec);
		if (HBCJPCMJPHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBCJPCMJPHE);
		}
		if (MOJBHKCPLDM != HADIBEMFDML.Imkmpbmamdg)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MOJBHKCPLDM);
		}
		if (MPNCPNILLJH != DKHAPDHBIFC.Ijappfeelpa)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MPNCPNILLJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PBPIOFGODHC other)
	{
		if (other != null)
		{
			if (other.DICEPCGFBNO != 0)
			{
				DICEPCGFBNO = other.DICEPCGFBNO;
			}
			mMFJGLOFLKL_.Add(other.mMFJGLOFLKL_);
			if (other.HBCJPCMJPHE != 0)
			{
				HBCJPCMJPHE = other.HBCJPCMJPHE;
			}
			if (other.MOJBHKCPLDM != HADIBEMFDML.Imkmpbmamdg)
			{
				MOJBHKCPLDM = other.MOJBHKCPLDM;
			}
			if (other.MPNCPNILLJH != DKHAPDHBIFC.Ijappfeelpa)
			{
				MPNCPNILLJH = other.MPNCPNILLJH;
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
			case 32u:
				DICEPCGFBNO = input.ReadUInt32();
				break;
			case 74u:
				mMFJGLOFLKL_.AddEntriesFrom(ref input, _repeated_mMFJGLOFLKL_codec);
				break;
			case 104u:
				HBCJPCMJPHE = input.ReadUInt32();
				break;
			case 112u:
				MOJBHKCPLDM = (HADIBEMFDML)input.ReadEnum();
				break;
			case 120u:
				MPNCPNILLJH = (DKHAPDHBIFC)input.ReadEnum();
				break;
			}
		}
	}
}
