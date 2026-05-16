using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLMPLHKEJLL : IMessage<PLMPLHKEJLL>, IMessage, IEquatable<PLMPLHKEJLL>, IDeepCloneable<PLMPLHKEJLL>, IBufferMessage
{
	private static readonly MessageParser<PLMPLHKEJLL> _parser = new MessageParser<PLMPLHKEJLL>(() => new PLMPLHKEJLL());

	private UnknownFieldSet _unknownFields;

	public const int BMKPIIGHODHFieldNumber = 2;

	private OLDMMODMOEI bMKPIIGHODH_;

	public const int IBOKGBFBKKDFieldNumber = 3;

	private static readonly FieldCodec<OAKIPKACMJF> _repeated_iBOKGBFBKKD_codec = FieldCodec.ForMessage(26u, OAKIPKACMJF.Parser);

	private readonly RepeatedField<OAKIPKACMJF> iBOKGBFBKKD_ = new RepeatedField<OAKIPKACMJF>();

	public const int OMCINMJNPIFFieldNumber = 4;

	private CPPAAIIHAGI oMCINMJNPIF_;

	public const int NBEEBMJFOEAFieldNumber = 6;

	private uint nBEEBMJFOEA_;

	public const int CHHAMIKKKCIFieldNumber = 9;

	private ChessRogueBoardCellStatus cHHAMIKKKCI_;

	public const int PNEMJFMGKJJFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_pNEMJFMGKJJ_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> pNEMJFMGKJJ_ = new RepeatedField<uint>();

	public const int HKBDJHLMIBFFieldNumber = 15;

	private uint hKBDJHLMIBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLMPLHKEJLL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLMPLHKEJLLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLDMMODMOEI BMKPIIGHODH
	{
		get
		{
			return bMKPIIGHODH_;
		}
		set
		{
			bMKPIIGHODH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OAKIPKACMJF> IBOKGBFBKKD => iBOKGBFBKKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPPAAIIHAGI OMCINMJNPIF
	{
		get
		{
			return oMCINMJNPIF_;
		}
		set
		{
			oMCINMJNPIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NBEEBMJFOEA
	{
		get
		{
			return nBEEBMJFOEA_;
		}
		set
		{
			nBEEBMJFOEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueBoardCellStatus CHHAMIKKKCI
	{
		get
		{
			return cHHAMIKKKCI_;
		}
		set
		{
			cHHAMIKKKCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PNEMJFMGKJJ => pNEMJFMGKJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HKBDJHLMIBF
	{
		get
		{
			return hKBDJHLMIBF_;
		}
		set
		{
			hKBDJHLMIBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLMPLHKEJLL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLMPLHKEJLL(PLMPLHKEJLL other)
		: this()
	{
		bMKPIIGHODH_ = ((other.bMKPIIGHODH_ != null) ? other.bMKPIIGHODH_.Clone() : null);
		iBOKGBFBKKD_ = other.iBOKGBFBKKD_.Clone();
		oMCINMJNPIF_ = ((other.oMCINMJNPIF_ != null) ? other.oMCINMJNPIF_.Clone() : null);
		nBEEBMJFOEA_ = other.nBEEBMJFOEA_;
		cHHAMIKKKCI_ = other.cHHAMIKKKCI_;
		pNEMJFMGKJJ_ = other.pNEMJFMGKJJ_.Clone();
		hKBDJHLMIBF_ = other.hKBDJHLMIBF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLMPLHKEJLL Clone()
	{
		return new PLMPLHKEJLL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLMPLHKEJLL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLMPLHKEJLL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BMKPIIGHODH, other.BMKPIIGHODH))
		{
			return false;
		}
		if (!iBOKGBFBKKD_.Equals(other.iBOKGBFBKKD_))
		{
			return false;
		}
		if (!object.Equals(OMCINMJNPIF, other.OMCINMJNPIF))
		{
			return false;
		}
		if (NBEEBMJFOEA != other.NBEEBMJFOEA)
		{
			return false;
		}
		if (CHHAMIKKKCI != other.CHHAMIKKKCI)
		{
			return false;
		}
		if (!pNEMJFMGKJJ_.Equals(other.pNEMJFMGKJJ_))
		{
			return false;
		}
		if (HKBDJHLMIBF != other.HKBDJHLMIBF)
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
		if (bMKPIIGHODH_ != null)
		{
			num ^= BMKPIIGHODH.GetHashCode();
		}
		num ^= iBOKGBFBKKD_.GetHashCode();
		if (oMCINMJNPIF_ != null)
		{
			num ^= OMCINMJNPIF.GetHashCode();
		}
		if (NBEEBMJFOEA != 0)
		{
			num ^= NBEEBMJFOEA.GetHashCode();
		}
		if (CHHAMIKKKCI != ChessRogueBoardCellStatus.GbikcjpglbkGhgapoakgab)
		{
			num ^= CHHAMIKKKCI.GetHashCode();
		}
		num ^= pNEMJFMGKJJ_.GetHashCode();
		if (HKBDJHLMIBF != 0)
		{
			num ^= HKBDJHLMIBF.GetHashCode();
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
		if (bMKPIIGHODH_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BMKPIIGHODH);
		}
		iBOKGBFBKKD_.WriteTo(ref output, _repeated_iBOKGBFBKKD_codec);
		if (oMCINMJNPIF_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OMCINMJNPIF);
		}
		if (NBEEBMJFOEA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NBEEBMJFOEA);
		}
		if (CHHAMIKKKCI != ChessRogueBoardCellStatus.GbikcjpglbkGhgapoakgab)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)CHHAMIKKKCI);
		}
		pNEMJFMGKJJ_.WriteTo(ref output, _repeated_pNEMJFMGKJJ_codec);
		if (HKBDJHLMIBF != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HKBDJHLMIBF);
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
		if (bMKPIIGHODH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMKPIIGHODH);
		}
		num += iBOKGBFBKKD_.CalculateSize(_repeated_iBOKGBFBKKD_codec);
		if (oMCINMJNPIF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OMCINMJNPIF);
		}
		if (NBEEBMJFOEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NBEEBMJFOEA);
		}
		if (CHHAMIKKKCI != ChessRogueBoardCellStatus.GbikcjpglbkGhgapoakgab)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CHHAMIKKKCI);
		}
		num += pNEMJFMGKJJ_.CalculateSize(_repeated_pNEMJFMGKJJ_codec);
		if (HKBDJHLMIBF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HKBDJHLMIBF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PLMPLHKEJLL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bMKPIIGHODH_ != null)
		{
			if (bMKPIIGHODH_ == null)
			{
				BMKPIIGHODH = new OLDMMODMOEI();
			}
			BMKPIIGHODH.MergeFrom(other.BMKPIIGHODH);
		}
		iBOKGBFBKKD_.Add(other.iBOKGBFBKKD_);
		if (other.oMCINMJNPIF_ != null)
		{
			if (oMCINMJNPIF_ == null)
			{
				OMCINMJNPIF = new CPPAAIIHAGI();
			}
			OMCINMJNPIF.MergeFrom(other.OMCINMJNPIF);
		}
		if (other.NBEEBMJFOEA != 0)
		{
			NBEEBMJFOEA = other.NBEEBMJFOEA;
		}
		if (other.CHHAMIKKKCI != ChessRogueBoardCellStatus.GbikcjpglbkGhgapoakgab)
		{
			CHHAMIKKKCI = other.CHHAMIKKKCI;
		}
		pNEMJFMGKJJ_.Add(other.pNEMJFMGKJJ_);
		if (other.HKBDJHLMIBF != 0)
		{
			HKBDJHLMIBF = other.HKBDJHLMIBF;
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
			case 18u:
				if (bMKPIIGHODH_ == null)
				{
					BMKPIIGHODH = new OLDMMODMOEI();
				}
				input.ReadMessage(BMKPIIGHODH);
				break;
			case 26u:
				iBOKGBFBKKD_.AddEntriesFrom(ref input, _repeated_iBOKGBFBKKD_codec);
				break;
			case 34u:
				if (oMCINMJNPIF_ == null)
				{
					OMCINMJNPIF = new CPPAAIIHAGI();
				}
				input.ReadMessage(OMCINMJNPIF);
				break;
			case 48u:
				NBEEBMJFOEA = input.ReadUInt32();
				break;
			case 72u:
				CHHAMIKKKCI = (ChessRogueBoardCellStatus)input.ReadEnum();
				break;
			case 88u:
			case 90u:
				pNEMJFMGKJJ_.AddEntriesFrom(ref input, _repeated_pNEMJFMGKJJ_codec);
				break;
			case 120u:
				HKBDJHLMIBF = input.ReadUInt32();
				break;
			}
		}
	}
}
