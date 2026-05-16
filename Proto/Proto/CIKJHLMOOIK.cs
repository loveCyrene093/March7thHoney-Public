using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIKJHLMOOIK : IMessage<CIKJHLMOOIK>, IMessage, IEquatable<CIKJHLMOOIK>, IDeepCloneable<CIKJHLMOOIK>, IBufferMessage
{
	private static readonly MessageParser<CIKJHLMOOIK> _parser = new MessageParser<CIKJHLMOOIK>(() => new CIKJHLMOOIK());

	private UnknownFieldSet _unknownFields;

	public const int DHHALBIANOGFieldNumber = 2;

	private PunkLordAttackerStatus dHHALBIANOG_;

	public const int GGGOOMKOJBFFieldNumber = 4;

	private uint gGGOOMKOJBF_;

	public const int BasicInfoFieldNumber = 11;

	private PunkLordMonsterBasicInfo basicInfo_;

	public const int FHPOILIMKIIFieldNumber = 12;

	private JOLDDNMGBHD fHPOILIMKII_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIKJHLMOOIK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIKJHLMOOIKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordAttackerStatus DHHALBIANOG
	{
		get
		{
			return dHHALBIANOG_;
		}
		set
		{
			dHHALBIANOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGGOOMKOJBF
	{
		get
		{
			return gGGOOMKOJBF_;
		}
		set
		{
			gGGOOMKOJBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterBasicInfo BasicInfo
	{
		get
		{
			return basicInfo_;
		}
		set
		{
			basicInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOLDDNMGBHD FHPOILIMKII
	{
		get
		{
			return fHPOILIMKII_;
		}
		set
		{
			fHPOILIMKII_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKJHLMOOIK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKJHLMOOIK(CIKJHLMOOIK other)
		: this()
	{
		dHHALBIANOG_ = other.dHHALBIANOG_;
		gGGOOMKOJBF_ = other.gGGOOMKOJBF_;
		basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
		fHPOILIMKII_ = ((other.fHPOILIMKII_ != null) ? other.fHPOILIMKII_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKJHLMOOIK Clone()
	{
		return new CIKJHLMOOIK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIKJHLMOOIK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIKJHLMOOIK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DHHALBIANOG != other.DHHALBIANOG)
		{
			return false;
		}
		if (GGGOOMKOJBF != other.GGGOOMKOJBF)
		{
			return false;
		}
		if (!object.Equals(BasicInfo, other.BasicInfo))
		{
			return false;
		}
		if (!object.Equals(FHPOILIMKII, other.FHPOILIMKII))
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
		if (DHHALBIANOG != PunkLordAttackerStatus.IhdhfkjhaahPcpdhelpkem)
		{
			num ^= DHHALBIANOG.GetHashCode();
		}
		if (GGGOOMKOJBF != 0)
		{
			num ^= GGGOOMKOJBF.GetHashCode();
		}
		if (basicInfo_ != null)
		{
			num ^= BasicInfo.GetHashCode();
		}
		if (fHPOILIMKII_ != null)
		{
			num ^= FHPOILIMKII.GetHashCode();
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
		if (DHHALBIANOG != PunkLordAttackerStatus.IhdhfkjhaahPcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DHHALBIANOG);
		}
		if (GGGOOMKOJBF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GGGOOMKOJBF);
		}
		if (basicInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(BasicInfo);
		}
		if (fHPOILIMKII_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FHPOILIMKII);
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
		if (DHHALBIANOG != PunkLordAttackerStatus.IhdhfkjhaahPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DHHALBIANOG);
		}
		if (GGGOOMKOJBF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GGGOOMKOJBF);
		}
		if (basicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BasicInfo);
		}
		if (fHPOILIMKII_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHPOILIMKII);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIKJHLMOOIK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DHHALBIANOG != PunkLordAttackerStatus.IhdhfkjhaahPcpdhelpkem)
		{
			DHHALBIANOG = other.DHHALBIANOG;
		}
		if (other.GGGOOMKOJBF != 0)
		{
			GGGOOMKOJBF = other.GGGOOMKOJBF;
		}
		if (other.basicInfo_ != null)
		{
			if (basicInfo_ == null)
			{
				BasicInfo = new PunkLordMonsterBasicInfo();
			}
			BasicInfo.MergeFrom(other.BasicInfo);
		}
		if (other.fHPOILIMKII_ != null)
		{
			if (fHPOILIMKII_ == null)
			{
				FHPOILIMKII = new JOLDDNMGBHD();
			}
			FHPOILIMKII.MergeFrom(other.FHPOILIMKII);
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
			case 16u:
				DHHALBIANOG = (PunkLordAttackerStatus)input.ReadEnum();
				break;
			case 32u:
				GGGOOMKOJBF = input.ReadUInt32();
				break;
			case 90u:
				if (basicInfo_ == null)
				{
					BasicInfo = new PunkLordMonsterBasicInfo();
				}
				input.ReadMessage(BasicInfo);
				break;
			case 98u:
				if (fHPOILIMKII_ == null)
				{
					FHPOILIMKII = new JOLDDNMGBHD();
				}
				input.ReadMessage(FHPOILIMKII);
				break;
			}
		}
	}
}
