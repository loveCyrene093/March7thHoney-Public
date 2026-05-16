using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraFinishEndlessRoundScRsp : IMessage<ChimeraFinishEndlessRoundScRsp>, IMessage, IEquatable<ChimeraFinishEndlessRoundScRsp>, IDeepCloneable<ChimeraFinishEndlessRoundScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChimeraFinishEndlessRoundScRsp> _parser = new MessageParser<ChimeraFinishEndlessRoundScRsp>(() => new ChimeraFinishEndlessRoundScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NKBDDIDFPNEFieldNumber = 3;

	private uint nKBDDIDFPNE_;

	public const int IFNODKPGBJKFieldNumber = 4;

	private static readonly FieldCodec<LEHNHDLEMHL> _repeated_iFNODKPGBJK_codec = FieldCodec.ForMessage(34u, LEHNHDLEMHL.Parser);

	private readonly RepeatedField<LEHNHDLEMHL> iFNODKPGBJK_ = new RepeatedField<LEHNHDLEMHL>();

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int HFJJJKEBMEPFieldNumber = 7;

	private uint hFJJJKEBMEP_;

	public const int JIICJOKLNLGFieldNumber = 10;

	private uint jIICJOKLNLG_;

	public const int OIPLJJIODILFieldNumber = 11;

	private bool oIPLJJIODIL_;

	public const int PKHBAMILIOIFieldNumber = 13;

	private uint pKHBAMILIOI_;

	public const int ACDJHFNHCNPFieldNumber = 14;

	private uint aCDJHFNHCNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraFinishEndlessRoundScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraFinishEndlessRoundScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NKBDDIDFPNE
	{
		get
		{
			return nKBDDIDFPNE_;
		}
		set
		{
			nKBDDIDFPNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LEHNHDLEMHL> IFNODKPGBJK => iFNODKPGBJK_;

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
	public uint HFJJJKEBMEP
	{
		get
		{
			return hFJJJKEBMEP_;
		}
		set
		{
			hFJJJKEBMEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JIICJOKLNLG
	{
		get
		{
			return jIICJOKLNLG_;
		}
		set
		{
			jIICJOKLNLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OIPLJJIODIL
	{
		get
		{
			return oIPLJJIODIL_;
		}
		set
		{
			oIPLJJIODIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKHBAMILIOI
	{
		get
		{
			return pKHBAMILIOI_;
		}
		set
		{
			pKHBAMILIOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACDJHFNHCNP
	{
		get
		{
			return aCDJHFNHCNP_;
		}
		set
		{
			aCDJHFNHCNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishEndlessRoundScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishEndlessRoundScRsp(ChimeraFinishEndlessRoundScRsp other)
		: this()
	{
		nKBDDIDFPNE_ = other.nKBDDIDFPNE_;
		iFNODKPGBJK_ = other.iFNODKPGBJK_.Clone();
		retcode_ = other.retcode_;
		hFJJJKEBMEP_ = other.hFJJJKEBMEP_;
		jIICJOKLNLG_ = other.jIICJOKLNLG_;
		oIPLJJIODIL_ = other.oIPLJJIODIL_;
		pKHBAMILIOI_ = other.pKHBAMILIOI_;
		aCDJHFNHCNP_ = other.aCDJHFNHCNP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishEndlessRoundScRsp Clone()
	{
		return new ChimeraFinishEndlessRoundScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraFinishEndlessRoundScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraFinishEndlessRoundScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NKBDDIDFPNE != other.NKBDDIDFPNE)
		{
			return false;
		}
		if (!iFNODKPGBJK_.Equals(other.iFNODKPGBJK_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (HFJJJKEBMEP != other.HFJJJKEBMEP)
		{
			return false;
		}
		if (JIICJOKLNLG != other.JIICJOKLNLG)
		{
			return false;
		}
		if (OIPLJJIODIL != other.OIPLJJIODIL)
		{
			return false;
		}
		if (PKHBAMILIOI != other.PKHBAMILIOI)
		{
			return false;
		}
		if (ACDJHFNHCNP != other.ACDJHFNHCNP)
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
		if (NKBDDIDFPNE != 0)
		{
			num ^= NKBDDIDFPNE.GetHashCode();
		}
		num ^= iFNODKPGBJK_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (HFJJJKEBMEP != 0)
		{
			num ^= HFJJJKEBMEP.GetHashCode();
		}
		if (JIICJOKLNLG != 0)
		{
			num ^= JIICJOKLNLG.GetHashCode();
		}
		if (OIPLJJIODIL)
		{
			num ^= OIPLJJIODIL.GetHashCode();
		}
		if (PKHBAMILIOI != 0)
		{
			num ^= PKHBAMILIOI.GetHashCode();
		}
		if (ACDJHFNHCNP != 0)
		{
			num ^= ACDJHFNHCNP.GetHashCode();
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
		if (NKBDDIDFPNE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NKBDDIDFPNE);
		}
		iFNODKPGBJK_.WriteTo(ref output, _repeated_iFNODKPGBJK_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (HFJJJKEBMEP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HFJJJKEBMEP);
		}
		if (JIICJOKLNLG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JIICJOKLNLG);
		}
		if (OIPLJJIODIL)
		{
			output.WriteRawTag(88);
			output.WriteBool(OIPLJJIODIL);
		}
		if (PKHBAMILIOI != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(PKHBAMILIOI);
		}
		if (ACDJHFNHCNP != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ACDJHFNHCNP);
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
		if (NKBDDIDFPNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NKBDDIDFPNE);
		}
		num += iFNODKPGBJK_.CalculateSize(_repeated_iFNODKPGBJK_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HFJJJKEBMEP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFJJJKEBMEP);
		}
		if (JIICJOKLNLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JIICJOKLNLG);
		}
		if (OIPLJJIODIL)
		{
			num += 2;
		}
		if (PKHBAMILIOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKHBAMILIOI);
		}
		if (ACDJHFNHCNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACDJHFNHCNP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraFinishEndlessRoundScRsp other)
	{
		if (other != null)
		{
			if (other.NKBDDIDFPNE != 0)
			{
				NKBDDIDFPNE = other.NKBDDIDFPNE;
			}
			iFNODKPGBJK_.Add(other.iFNODKPGBJK_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.HFJJJKEBMEP != 0)
			{
				HFJJJKEBMEP = other.HFJJJKEBMEP;
			}
			if (other.JIICJOKLNLG != 0)
			{
				JIICJOKLNLG = other.JIICJOKLNLG;
			}
			if (other.OIPLJJIODIL)
			{
				OIPLJJIODIL = other.OIPLJJIODIL;
			}
			if (other.PKHBAMILIOI != 0)
			{
				PKHBAMILIOI = other.PKHBAMILIOI;
			}
			if (other.ACDJHFNHCNP != 0)
			{
				ACDJHFNHCNP = other.ACDJHFNHCNP;
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
			case 24u:
				NKBDDIDFPNE = input.ReadUInt32();
				break;
			case 34u:
				iFNODKPGBJK_.AddEntriesFrom(ref input, _repeated_iFNODKPGBJK_codec);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 56u:
				HFJJJKEBMEP = input.ReadUInt32();
				break;
			case 80u:
				JIICJOKLNLG = input.ReadUInt32();
				break;
			case 88u:
				OIPLJJIODIL = input.ReadBool();
				break;
			case 104u:
				PKHBAMILIOI = input.ReadUInt32();
				break;
			case 112u:
				ACDJHFNHCNP = input.ReadUInt32();
				break;
			}
		}
	}
}
