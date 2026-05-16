using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingFinishBattleCsReq : IMessage<ChenLingFinishBattleCsReq>, IMessage, IEquatable<ChenLingFinishBattleCsReq>, IDeepCloneable<ChenLingFinishBattleCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingFinishBattleCsReq> _parser = new MessageParser<ChenLingFinishBattleCsReq>(() => new ChenLingFinishBattleCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PJLADGOOFKEFieldNumber = 6;

	private uint pJLADGOOFKE_;

	public const int DKMPDLPEIJBFieldNumber = 8;

	private uint dKMPDLPEIJB_;

	public const int HAIOHANDIKIFieldNumber = 9;

	private static readonly FieldCodec<LKFNDAOGMMO> _repeated_hAIOHANDIKI_codec = FieldCodec.ForMessage(74u, LKFNDAOGMMO.Parser);

	private readonly RepeatedField<LKFNDAOGMMO> hAIOHANDIKI_ = new RepeatedField<LKFNDAOGMMO>();

	public const int LMIICENMOBIFieldNumber = 10;

	private uint lMIICENMOBI_;

	public const int IsWinFieldNumber = 14;

	private bool isWin_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingFinishBattleCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingFinishBattleCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJLADGOOFKE
	{
		get
		{
			return pJLADGOOFKE_;
		}
		set
		{
			pJLADGOOFKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKMPDLPEIJB
	{
		get
		{
			return dKMPDLPEIJB_;
		}
		set
		{
			dKMPDLPEIJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LKFNDAOGMMO> HAIOHANDIKI => hAIOHANDIKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMIICENMOBI
	{
		get
		{
			return lMIICENMOBI_;
		}
		set
		{
			lMIICENMOBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingFinishBattleCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingFinishBattleCsReq(ChenLingFinishBattleCsReq other)
		: this()
	{
		pJLADGOOFKE_ = other.pJLADGOOFKE_;
		dKMPDLPEIJB_ = other.dKMPDLPEIJB_;
		hAIOHANDIKI_ = other.hAIOHANDIKI_.Clone();
		lMIICENMOBI_ = other.lMIICENMOBI_;
		isWin_ = other.isWin_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingFinishBattleCsReq Clone()
	{
		return new ChenLingFinishBattleCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingFinishBattleCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingFinishBattleCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJLADGOOFKE != other.PJLADGOOFKE)
		{
			return false;
		}
		if (DKMPDLPEIJB != other.DKMPDLPEIJB)
		{
			return false;
		}
		if (!hAIOHANDIKI_.Equals(other.hAIOHANDIKI_))
		{
			return false;
		}
		if (LMIICENMOBI != other.LMIICENMOBI)
		{
			return false;
		}
		if (IsWin != other.IsWin)
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
		if (PJLADGOOFKE != 0)
		{
			num ^= PJLADGOOFKE.GetHashCode();
		}
		if (DKMPDLPEIJB != 0)
		{
			num ^= DKMPDLPEIJB.GetHashCode();
		}
		num ^= hAIOHANDIKI_.GetHashCode();
		if (LMIICENMOBI != 0)
		{
			num ^= LMIICENMOBI.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
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
		if (PJLADGOOFKE != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PJLADGOOFKE);
		}
		if (DKMPDLPEIJB != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DKMPDLPEIJB);
		}
		hAIOHANDIKI_.WriteTo(ref output, _repeated_hAIOHANDIKI_codec);
		if (LMIICENMOBI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(LMIICENMOBI);
		}
		if (IsWin)
		{
			output.WriteRawTag(112);
			output.WriteBool(IsWin);
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
		if (PJLADGOOFKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJLADGOOFKE);
		}
		if (DKMPDLPEIJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKMPDLPEIJB);
		}
		num += hAIOHANDIKI_.CalculateSize(_repeated_hAIOHANDIKI_codec);
		if (LMIICENMOBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMIICENMOBI);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingFinishBattleCsReq other)
	{
		if (other != null)
		{
			if (other.PJLADGOOFKE != 0)
			{
				PJLADGOOFKE = other.PJLADGOOFKE;
			}
			if (other.DKMPDLPEIJB != 0)
			{
				DKMPDLPEIJB = other.DKMPDLPEIJB;
			}
			hAIOHANDIKI_.Add(other.hAIOHANDIKI_);
			if (other.LMIICENMOBI != 0)
			{
				LMIICENMOBI = other.LMIICENMOBI;
			}
			if (other.IsWin)
			{
				IsWin = other.IsWin;
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
			case 48u:
				PJLADGOOFKE = input.ReadUInt32();
				break;
			case 64u:
				DKMPDLPEIJB = input.ReadUInt32();
				break;
			case 74u:
				hAIOHANDIKI_.AddEntriesFrom(ref input, _repeated_hAIOHANDIKI_codec);
				break;
			case 80u:
				LMIICENMOBI = input.ReadUInt32();
				break;
			case 112u:
				IsWin = input.ReadBool();
				break;
			}
		}
	}
}
