using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOIJNCLJGKO : IMessage<DOIJNCLJGKO>, IMessage, IEquatable<DOIJNCLJGKO>, IDeepCloneable<DOIJNCLJGKO>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		FJNNJNHACAB = 1,
		AGPGDEPJAJM = 7,
		ANGMBDBAOIH = 12
	}

	private static readonly MessageParser<DOIJNCLJGKO> _parser = new MessageParser<DOIJNCLJGKO>(() => new DOIJNCLJGKO());

	private UnknownFieldSet _unknownFields;

	public const int ALFHNEHOBJAFieldNumber = 2;

	private RogueModifierSourceType aLFHNEHOBJA_;

	public const int PIMNEEFDAGEFieldNumber = 11;

	private ulong pIMNEEFDAGE_;

	public const int IMPOEHIOCBCFieldNumber = 14;

	private GJFAPKAGEED iMPOEHIOCBC_;

	public const int FJNNJNHACABFieldNumber = 1;

	public const int AGPGDEPJAJMFieldNumber = 7;

	public const int ANGMBDBAOIHFieldNumber = 12;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOIJNCLJGKO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOIJNCLJGKOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueModifierSourceType ALFHNEHOBJA
	{
		get
		{
			return aLFHNEHOBJA_;
		}
		set
		{
			aLFHNEHOBJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PIMNEEFDAGE
	{
		get
		{
			return pIMNEEFDAGE_;
		}
		set
		{
			pIMNEEFDAGE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJFAPKAGEED IMPOEHIOCBC
	{
		get
		{
			return iMPOEHIOCBC_;
		}
		set
		{
			iMPOEHIOCBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBDPCIIFFON FJNNJNHACAB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FJNNJNHACAB)
			{
				return null;
			}
			return (EBDPCIIFFON)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FJNNJNHACAB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJGHOBOEODL AGPGDEPJAJM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AGPGDEPJAJM)
			{
				return null;
			}
			return (MJGHOBOEODL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AGPGDEPJAJM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAPBFNBKFHM ANGMBDBAOIH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ANGMBDBAOIH)
			{
				return null;
			}
			return (OAPBFNBKFHM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ANGMBDBAOIH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOIJNCLJGKO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOIJNCLJGKO(DOIJNCLJGKO other)
		: this()
	{
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		pIMNEEFDAGE_ = other.pIMNEEFDAGE_;
		iMPOEHIOCBC_ = ((other.iMPOEHIOCBC_ != null) ? other.iMPOEHIOCBC_.Clone() : null);
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.FJNNJNHACAB:
			FJNNJNHACAB = other.FJNNJNHACAB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AGPGDEPJAJM:
			AGPGDEPJAJM = other.AGPGDEPJAJM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ANGMBDBAOIH:
			ANGMBDBAOIH = other.ANGMBDBAOIH.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOIJNCLJGKO Clone()
	{
		return new DOIJNCLJGKO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOIJNCLJGKO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOIJNCLJGKO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
		{
			return false;
		}
		if (PIMNEEFDAGE != other.PIMNEEFDAGE)
		{
			return false;
		}
		if (!object.Equals(IMPOEHIOCBC, other.IMPOEHIOCBC))
		{
			return false;
		}
		if (!object.Equals(FJNNJNHACAB, other.FJNNJNHACAB))
		{
			return false;
		}
		if (!object.Equals(AGPGDEPJAJM, other.AGPGDEPJAJM))
		{
			return false;
		}
		if (!object.Equals(ANGMBDBAOIH, other.ANGMBDBAOIH))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (ALFHNEHOBJA != RogueModifierSourceType.KiellbkoaloChodnmohlpn)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
		}
		if (PIMNEEFDAGE != 0L)
		{
			num ^= PIMNEEFDAGE.GetHashCode();
		}
		if (iMPOEHIOCBC_ != null)
		{
			num ^= IMPOEHIOCBC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FJNNJNHACAB)
		{
			num ^= FJNNJNHACAB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGPGDEPJAJM)
		{
			num ^= AGPGDEPJAJM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ANGMBDBAOIH)
		{
			num ^= ANGMBDBAOIH.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FJNNJNHACAB)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FJNNJNHACAB);
		}
		if (ALFHNEHOBJA != RogueModifierSourceType.KiellbkoaloChodnmohlpn)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ALFHNEHOBJA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGPGDEPJAJM)
		{
			output.WriteRawTag(58);
			output.WriteMessage(AGPGDEPJAJM);
		}
		if (PIMNEEFDAGE != 0L)
		{
			output.WriteRawTag(88);
			output.WriteUInt64(PIMNEEFDAGE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ANGMBDBAOIH)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ANGMBDBAOIH);
		}
		if (iMPOEHIOCBC_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(IMPOEHIOCBC);
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
		if (ALFHNEHOBJA != RogueModifierSourceType.KiellbkoaloChodnmohlpn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (PIMNEEFDAGE != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PIMNEEFDAGE);
		}
		if (iMPOEHIOCBC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPOEHIOCBC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FJNNJNHACAB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FJNNJNHACAB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGPGDEPJAJM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AGPGDEPJAJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ANGMBDBAOIH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ANGMBDBAOIH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DOIJNCLJGKO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ALFHNEHOBJA != RogueModifierSourceType.KiellbkoaloChodnmohlpn)
		{
			ALFHNEHOBJA = other.ALFHNEHOBJA;
		}
		if (other.PIMNEEFDAGE != 0L)
		{
			PIMNEEFDAGE = other.PIMNEEFDAGE;
		}
		if (other.iMPOEHIOCBC_ != null)
		{
			if (iMPOEHIOCBC_ == null)
			{
				IMPOEHIOCBC = new GJFAPKAGEED();
			}
			IMPOEHIOCBC.MergeFrom(other.IMPOEHIOCBC);
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.FJNNJNHACAB:
			if (FJNNJNHACAB == null)
			{
				FJNNJNHACAB = new EBDPCIIFFON();
			}
			FJNNJNHACAB.MergeFrom(other.FJNNJNHACAB);
			break;
		case BPIHFAJCLOCOneofCase.AGPGDEPJAJM:
			if (AGPGDEPJAJM == null)
			{
				AGPGDEPJAJM = new MJGHOBOEODL();
			}
			AGPGDEPJAJM.MergeFrom(other.AGPGDEPJAJM);
			break;
		case BPIHFAJCLOCOneofCase.ANGMBDBAOIH:
			if (ANGMBDBAOIH == null)
			{
				ANGMBDBAOIH = new OAPBFNBKFHM();
			}
			ANGMBDBAOIH.MergeFrom(other.ANGMBDBAOIH);
			break;
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
			{
				EBDPCIIFFON eBDPCIIFFON = new EBDPCIIFFON();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FJNNJNHACAB)
				{
					eBDPCIIFFON.MergeFrom(FJNNJNHACAB);
				}
				input.ReadMessage(eBDPCIIFFON);
				FJNNJNHACAB = eBDPCIIFFON;
				break;
			}
			case 16u:
				ALFHNEHOBJA = (RogueModifierSourceType)input.ReadEnum();
				break;
			case 58u:
			{
				MJGHOBOEODL mJGHOBOEODL = new MJGHOBOEODL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGPGDEPJAJM)
				{
					mJGHOBOEODL.MergeFrom(AGPGDEPJAJM);
				}
				input.ReadMessage(mJGHOBOEODL);
				AGPGDEPJAJM = mJGHOBOEODL;
				break;
			}
			case 88u:
				PIMNEEFDAGE = input.ReadUInt64();
				break;
			case 98u:
			{
				OAPBFNBKFHM oAPBFNBKFHM = new OAPBFNBKFHM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ANGMBDBAOIH)
				{
					oAPBFNBKFHM.MergeFrom(ANGMBDBAOIH);
				}
				input.ReadMessage(oAPBFNBKFHM);
				ANGMBDBAOIH = oAPBFNBKFHM;
				break;
			}
			case 114u:
				if (iMPOEHIOCBC_ == null)
				{
					IMPOEHIOCBC = new GJFAPKAGEED();
				}
				input.ReadMessage(IMPOEHIOCBC);
				break;
			}
		}
	}
}
