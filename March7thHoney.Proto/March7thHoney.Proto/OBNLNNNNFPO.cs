using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OBNLNNNNFPO : IMessage<OBNLNNNNFPO>, IMessage, IEquatable<OBNLNNNNFPO>, IDeepCloneable<OBNLNNNNFPO>, IBufferMessage
{
	private static readonly MessageParser<OBNLNNNNFPO> _parser = new MessageParser<OBNLNNNNFPO>(() => new OBNLNNNNFPO());

	private UnknownFieldSet _unknownFields;

	public const int EIIAGABAFECFieldNumber = 1;

	private uint eIIAGABAFEC_;

	public const int POICOLMBMIGFieldNumber = 5;

	private bool pOICOLMBMIG_;

	public const int JAFNCOMGABGFieldNumber = 6;

	private uint jAFNCOMGABG_;

	public const int KPFHBDDEKLJFieldNumber = 8;

	private uint kPFHBDDEKLJ_;

	public const int IALJOJMAFLLFieldNumber = 12;

	private uint iALJOJMAFLL_;

	public const int KOCGGHPKFAPFieldNumber = 14;

	private bool kOCGGHPKFAP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OBNLNNNNFPO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OBNLNNNNFPOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool POICOLMBMIG
	{
		get
		{
			return pOICOLMBMIG_;
		}
		set
		{
			pOICOLMBMIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPFHBDDEKLJ
	{
		get
		{
			return kPFHBDDEKLJ_;
		}
		set
		{
			kPFHBDDEKLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IALJOJMAFLL
	{
		get
		{
			return iALJOJMAFLL_;
		}
		set
		{
			iALJOJMAFLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KOCGGHPKFAP
	{
		get
		{
			return kOCGGHPKFAP_;
		}
		set
		{
			kOCGGHPKFAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBNLNNNNFPO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBNLNNNNFPO(OBNLNNNNFPO other)
		: this()
	{
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		pOICOLMBMIG_ = other.pOICOLMBMIG_;
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		kPFHBDDEKLJ_ = other.kPFHBDDEKLJ_;
		iALJOJMAFLL_ = other.iALJOJMAFLL_;
		kOCGGHPKFAP_ = other.kOCGGHPKFAP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBNLNNNNFPO Clone()
	{
		return new OBNLNNNNFPO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OBNLNNNNFPO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OBNLNNNNFPO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
		{
			return false;
		}
		if (POICOLMBMIG != other.POICOLMBMIG)
		{
			return false;
		}
		if (JAFNCOMGABG != other.JAFNCOMGABG)
		{
			return false;
		}
		if (KPFHBDDEKLJ != other.KPFHBDDEKLJ)
		{
			return false;
		}
		if (IALJOJMAFLL != other.IALJOJMAFLL)
		{
			return false;
		}
		if (KOCGGHPKFAP != other.KOCGGHPKFAP)
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
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
		if (POICOLMBMIG)
		{
			num ^= POICOLMBMIG.GetHashCode();
		}
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
		}
		if (KPFHBDDEKLJ != 0)
		{
			num ^= KPFHBDDEKLJ.GetHashCode();
		}
		if (IALJOJMAFLL != 0)
		{
			num ^= IALJOJMAFLL.GetHashCode();
		}
		if (KOCGGHPKFAP)
		{
			num ^= KOCGGHPKFAP.GetHashCode();
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
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (POICOLMBMIG)
		{
			output.WriteRawTag(40);
			output.WriteBool(POICOLMBMIG);
		}
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JAFNCOMGABG);
		}
		if (KPFHBDDEKLJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(KPFHBDDEKLJ);
		}
		if (IALJOJMAFLL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(IALJOJMAFLL);
		}
		if (KOCGGHPKFAP)
		{
			output.WriteRawTag(112);
			output.WriteBool(KOCGGHPKFAP);
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
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (POICOLMBMIG)
		{
			num += 2;
		}
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (KPFHBDDEKLJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPFHBDDEKLJ);
		}
		if (IALJOJMAFLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IALJOJMAFLL);
		}
		if (KOCGGHPKFAP)
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
	public void MergeFrom(OBNLNNNNFPO other)
	{
		if (other != null)
		{
			if (other.EIIAGABAFEC != 0)
			{
				EIIAGABAFEC = other.EIIAGABAFEC;
			}
			if (other.POICOLMBMIG)
			{
				POICOLMBMIG = other.POICOLMBMIG;
			}
			if (other.JAFNCOMGABG != 0)
			{
				JAFNCOMGABG = other.JAFNCOMGABG;
			}
			if (other.KPFHBDDEKLJ != 0)
			{
				KPFHBDDEKLJ = other.KPFHBDDEKLJ;
			}
			if (other.IALJOJMAFLL != 0)
			{
				IALJOJMAFLL = other.IALJOJMAFLL;
			}
			if (other.KOCGGHPKFAP)
			{
				KOCGGHPKFAP = other.KOCGGHPKFAP;
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
			case 8u:
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 40u:
				POICOLMBMIG = input.ReadBool();
				break;
			case 48u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			case 64u:
				KPFHBDDEKLJ = input.ReadUInt32();
				break;
			case 96u:
				IALJOJMAFLL = input.ReadUInt32();
				break;
			case 112u:
				KOCGGHPKFAP = input.ReadBool();
				break;
			}
		}
	}
}
