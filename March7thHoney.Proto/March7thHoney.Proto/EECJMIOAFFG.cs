using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EECJMIOAFFG : IMessage<EECJMIOAFFG>, IMessage, IEquatable<EECJMIOAFFG>, IDeepCloneable<EECJMIOAFFG>, IBufferMessage
{
	private static readonly MessageParser<EECJMIOAFFG> _parser = new MessageParser<EECJMIOAFFG>(() => new EECJMIOAFFG());

	private UnknownFieldSet _unknownFields;

	public const int HMIHLDPMPOMFieldNumber = 1;

	private OBOKDHDOKAD hMIHLDPMPOM_;

	public const int BHPLKHAMBIGFieldNumber = 5;

	private uint bHPLKHAMBIG_;

	public const int EKLKHPGDPOLFieldNumber = 6;

	private long eKLKHPGDPOL_;

	public const int NameFieldNumber = 7;

	private string name_ = "";

	public const int KKGIEENCOICFieldNumber = 9;

	private uint kKGIEENCOIC_;

	public const int IsMarkedFieldNumber = 11;

	private bool isMarked_;

	public const int JHHHONJIKGLFieldNumber = 14;

	private FOFBDBJBEJE jHHHONJIKGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EECJMIOAFFG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EECJMIOAFFGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBOKDHDOKAD HMIHLDPMPOM
	{
		get
		{
			return hMIHLDPMPOM_;
		}
		set
		{
			hMIHLDPMPOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHPLKHAMBIG
	{
		get
		{
			return bHPLKHAMBIG_;
		}
		set
		{
			bHPLKHAMBIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EKLKHPGDPOL
	{
		get
		{
			return eKLKHPGDPOL_;
		}
		set
		{
			eKLKHPGDPOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKGIEENCOIC
	{
		get
		{
			return kKGIEENCOIC_;
		}
		set
		{
			kKGIEENCOIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsMarked
	{
		get
		{
			return isMarked_;
		}
		set
		{
			isMarked_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFBDBJBEJE JHHHONJIKGL
	{
		get
		{
			return jHHHONJIKGL_;
		}
		set
		{
			jHHHONJIKGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EECJMIOAFFG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EECJMIOAFFG(EECJMIOAFFG other)
		: this()
	{
		hMIHLDPMPOM_ = ((other.hMIHLDPMPOM_ != null) ? other.hMIHLDPMPOM_.Clone() : null);
		bHPLKHAMBIG_ = other.bHPLKHAMBIG_;
		eKLKHPGDPOL_ = other.eKLKHPGDPOL_;
		name_ = other.name_;
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		isMarked_ = other.isMarked_;
		jHHHONJIKGL_ = ((other.jHHHONJIKGL_ != null) ? other.jHHHONJIKGL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EECJMIOAFFG Clone()
	{
		return new EECJMIOAFFG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EECJMIOAFFG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EECJMIOAFFG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HMIHLDPMPOM, other.HMIHLDPMPOM))
		{
			return false;
		}
		if (BHPLKHAMBIG != other.BHPLKHAMBIG)
		{
			return false;
		}
		if (EKLKHPGDPOL != other.EKLKHPGDPOL)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
		{
			return false;
		}
		if (IsMarked != other.IsMarked)
		{
			return false;
		}
		if (!object.Equals(JHHHONJIKGL, other.JHHHONJIKGL))
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
		if (hMIHLDPMPOM_ != null)
		{
			num ^= HMIHLDPMPOM.GetHashCode();
		}
		if (BHPLKHAMBIG != 0)
		{
			num ^= BHPLKHAMBIG.GetHashCode();
		}
		if (EKLKHPGDPOL != 0L)
		{
			num ^= EKLKHPGDPOL.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
		}
		if (IsMarked)
		{
			num ^= IsMarked.GetHashCode();
		}
		if (jHHHONJIKGL_ != null)
		{
			num ^= JHHHONJIKGL.GetHashCode();
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
		if (hMIHLDPMPOM_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HMIHLDPMPOM);
		}
		if (BHPLKHAMBIG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BHPLKHAMBIG);
		}
		if (EKLKHPGDPOL != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(EKLKHPGDPOL);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Name);
		}
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KKGIEENCOIC);
		}
		if (IsMarked)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsMarked);
		}
		if (jHHHONJIKGL_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(JHHHONJIKGL);
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
		if (hMIHLDPMPOM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMIHLDPMPOM);
		}
		if (BHPLKHAMBIG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHPLKHAMBIG);
		}
		if (EKLKHPGDPOL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EKLKHPGDPOL);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (IsMarked)
		{
			num += 2;
		}
		if (jHHHONJIKGL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHHHONJIKGL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EECJMIOAFFG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hMIHLDPMPOM_ != null)
		{
			if (hMIHLDPMPOM_ == null)
			{
				HMIHLDPMPOM = new OBOKDHDOKAD();
			}
			HMIHLDPMPOM.MergeFrom(other.HMIHLDPMPOM);
		}
		if (other.BHPLKHAMBIG != 0)
		{
			BHPLKHAMBIG = other.BHPLKHAMBIG;
		}
		if (other.EKLKHPGDPOL != 0L)
		{
			EKLKHPGDPOL = other.EKLKHPGDPOL;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.KKGIEENCOIC != 0)
		{
			KKGIEENCOIC = other.KKGIEENCOIC;
		}
		if (other.IsMarked)
		{
			IsMarked = other.IsMarked;
		}
		if (other.jHHHONJIKGL_ != null)
		{
			if (jHHHONJIKGL_ == null)
			{
				JHHHONJIKGL = new FOFBDBJBEJE();
			}
			JHHHONJIKGL.MergeFrom(other.JHHHONJIKGL);
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
				if (hMIHLDPMPOM_ == null)
				{
					HMIHLDPMPOM = new OBOKDHDOKAD();
				}
				input.ReadMessage(HMIHLDPMPOM);
				break;
			case 40u:
				BHPLKHAMBIG = input.ReadUInt32();
				break;
			case 48u:
				EKLKHPGDPOL = input.ReadInt64();
				break;
			case 58u:
				Name = input.ReadString();
				break;
			case 72u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 88u:
				IsMarked = input.ReadBool();
				break;
			case 114u:
				if (jHHHONJIKGL_ == null)
				{
					JHHHONJIKGL = new FOFBDBJBEJE();
				}
				input.ReadMessage(JHHHONJIKGL);
				break;
			}
		}
	}
}
