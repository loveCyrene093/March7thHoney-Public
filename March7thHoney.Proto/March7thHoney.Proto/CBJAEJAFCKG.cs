using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CBJAEJAFCKG : IMessage<CBJAEJAFCKG>, IMessage, IEquatable<CBJAEJAFCKG>, IDeepCloneable<CBJAEJAFCKG>, IBufferMessage
{
	private static readonly MessageParser<CBJAEJAFCKG> _parser = new MessageParser<CBJAEJAFCKG>(() => new CBJAEJAFCKG());

	private UnknownFieldSet _unknownFields;

	public const int OFHCNGHJFHIFieldNumber = 1;

	private uint oFHCNGHJFHI_;

	public const int OKOBGFHGIJBFieldNumber = 2;

	private uint oKOBGFHGIJB_;

	public const int ECBILPPLFIIFieldNumber = 5;

	private ItemCostData eCBILPPLFII_;

	public const int DEFDJJPLBPGFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_dEFDJJPLBPG_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> dEFDJJPLBPG_ = new RepeatedField<uint>();

	public const int OJAPMNAPIFGFieldNumber = 7;

	private bool oJAPMNAPIFG_;

	public const int FBDKDEBJFGBFieldNumber = 9;

	private uint fBDKDEBJFGB_;

	public const int HFPGMBAKBMBFieldNumber = 14;

	private uint hFPGMBAKBMB_;

	public const int DOJNIHGIDKEFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_dOJNIHGIDKE_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> dOJNIHGIDKE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CBJAEJAFCKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CBJAEJAFCKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFHCNGHJFHI
	{
		get
		{
			return oFHCNGHJFHI_;
		}
		set
		{
			oFHCNGHJFHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OKOBGFHGIJB
	{
		get
		{
			return oKOBGFHGIJB_;
		}
		set
		{
			oKOBGFHGIJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData ECBILPPLFII
	{
		get
		{
			return eCBILPPLFII_;
		}
		set
		{
			eCBILPPLFII_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DEFDJJPLBPG => dEFDJJPLBPG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OJAPMNAPIFG
	{
		get
		{
			return oJAPMNAPIFG_;
		}
		set
		{
			oJAPMNAPIFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBDKDEBJFGB
	{
		get
		{
			return fBDKDEBJFGB_;
		}
		set
		{
			fBDKDEBJFGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFPGMBAKBMB
	{
		get
		{
			return hFPGMBAKBMB_;
		}
		set
		{
			hFPGMBAKBMB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DOJNIHGIDKE => dOJNIHGIDKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBJAEJAFCKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBJAEJAFCKG(CBJAEJAFCKG other)
		: this()
	{
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		oKOBGFHGIJB_ = other.oKOBGFHGIJB_;
		eCBILPPLFII_ = ((other.eCBILPPLFII_ != null) ? other.eCBILPPLFII_.Clone() : null);
		dEFDJJPLBPG_ = other.dEFDJJPLBPG_.Clone();
		oJAPMNAPIFG_ = other.oJAPMNAPIFG_;
		fBDKDEBJFGB_ = other.fBDKDEBJFGB_;
		hFPGMBAKBMB_ = other.hFPGMBAKBMB_;
		dOJNIHGIDKE_ = other.dOJNIHGIDKE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBJAEJAFCKG Clone()
	{
		return new CBJAEJAFCKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CBJAEJAFCKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CBJAEJAFCKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
		{
			return false;
		}
		if (OKOBGFHGIJB != other.OKOBGFHGIJB)
		{
			return false;
		}
		if (!object.Equals(ECBILPPLFII, other.ECBILPPLFII))
		{
			return false;
		}
		if (!dEFDJJPLBPG_.Equals(other.dEFDJJPLBPG_))
		{
			return false;
		}
		if (OJAPMNAPIFG != other.OJAPMNAPIFG)
		{
			return false;
		}
		if (FBDKDEBJFGB != other.FBDKDEBJFGB)
		{
			return false;
		}
		if (HFPGMBAKBMB != other.HFPGMBAKBMB)
		{
			return false;
		}
		if (!dOJNIHGIDKE_.Equals(other.dOJNIHGIDKE_))
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
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
		}
		if (OKOBGFHGIJB != 0)
		{
			num ^= OKOBGFHGIJB.GetHashCode();
		}
		if (eCBILPPLFII_ != null)
		{
			num ^= ECBILPPLFII.GetHashCode();
		}
		num ^= dEFDJJPLBPG_.GetHashCode();
		if (OJAPMNAPIFG)
		{
			num ^= OJAPMNAPIFG.GetHashCode();
		}
		if (FBDKDEBJFGB != 0)
		{
			num ^= FBDKDEBJFGB.GetHashCode();
		}
		if (HFPGMBAKBMB != 0)
		{
			num ^= HFPGMBAKBMB.GetHashCode();
		}
		num ^= dOJNIHGIDKE_.GetHashCode();
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
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		if (OKOBGFHGIJB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(OKOBGFHGIJB);
		}
		if (eCBILPPLFII_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ECBILPPLFII);
		}
		dEFDJJPLBPG_.WriteTo(ref output, _repeated_dEFDJJPLBPG_codec);
		if (OJAPMNAPIFG)
		{
			output.WriteRawTag(56);
			output.WriteBool(OJAPMNAPIFG);
		}
		if (FBDKDEBJFGB != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FBDKDEBJFGB);
		}
		if (HFPGMBAKBMB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HFPGMBAKBMB);
		}
		dOJNIHGIDKE_.WriteTo(ref output, _repeated_dOJNIHGIDKE_codec);
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
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		if (OKOBGFHGIJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKOBGFHGIJB);
		}
		if (eCBILPPLFII_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ECBILPPLFII);
		}
		num += dEFDJJPLBPG_.CalculateSize(_repeated_dEFDJJPLBPG_codec);
		if (OJAPMNAPIFG)
		{
			num += 2;
		}
		if (FBDKDEBJFGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBDKDEBJFGB);
		}
		if (HFPGMBAKBMB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFPGMBAKBMB);
		}
		num += dOJNIHGIDKE_.CalculateSize(_repeated_dOJNIHGIDKE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CBJAEJAFCKG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OFHCNGHJFHI != 0)
		{
			OFHCNGHJFHI = other.OFHCNGHJFHI;
		}
		if (other.OKOBGFHGIJB != 0)
		{
			OKOBGFHGIJB = other.OKOBGFHGIJB;
		}
		if (other.eCBILPPLFII_ != null)
		{
			if (eCBILPPLFII_ == null)
			{
				ECBILPPLFII = new ItemCostData();
			}
			ECBILPPLFII.MergeFrom(other.ECBILPPLFII);
		}
		dEFDJJPLBPG_.Add(other.dEFDJJPLBPG_);
		if (other.OJAPMNAPIFG)
		{
			OJAPMNAPIFG = other.OJAPMNAPIFG;
		}
		if (other.FBDKDEBJFGB != 0)
		{
			FBDKDEBJFGB = other.FBDKDEBJFGB;
		}
		if (other.HFPGMBAKBMB != 0)
		{
			HFPGMBAKBMB = other.HFPGMBAKBMB;
		}
		dOJNIHGIDKE_.Add(other.dOJNIHGIDKE_);
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
			case 8u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 16u:
				OKOBGFHGIJB = input.ReadUInt32();
				break;
			case 42u:
				if (eCBILPPLFII_ == null)
				{
					ECBILPPLFII = new ItemCostData();
				}
				input.ReadMessage(ECBILPPLFII);
				break;
			case 48u:
			case 50u:
				dEFDJJPLBPG_.AddEntriesFrom(ref input, _repeated_dEFDJJPLBPG_codec);
				break;
			case 56u:
				OJAPMNAPIFG = input.ReadBool();
				break;
			case 72u:
				FBDKDEBJFGB = input.ReadUInt32();
				break;
			case 112u:
				HFPGMBAKBMB = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				dOJNIHGIDKE_.AddEntriesFrom(ref input, _repeated_dOJNIHGIDKE_codec);
				break;
			}
		}
	}
}
