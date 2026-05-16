using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ModifyRelicFilterPlanScRsp : IMessage<ModifyRelicFilterPlanScRsp>, IMessage, IEquatable<ModifyRelicFilterPlanScRsp>, IDeepCloneable<ModifyRelicFilterPlanScRsp>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		JHHHONJIKGL = 1,
		Name = 2,
		HMIHLDPMPOM = 10
	}

	private static readonly MessageParser<ModifyRelicFilterPlanScRsp> _parser = new MessageParser<ModifyRelicFilterPlanScRsp>(() => new ModifyRelicFilterPlanScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int KKGIEENCOICFieldNumber = 8;

	private uint kKGIEENCOIC_;

	public const int EKLKHPGDPOLFieldNumber = 14;

	private long eKLKHPGDPOL_;

	public const int JHHHONJIKGLFieldNumber = 1;

	public const int NameFieldNumber = 2;

	public const int HMIHLDPMPOMFieldNumber = 10;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ModifyRelicFilterPlanScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ModifyRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FOFBDBJBEJE JHHHONJIKGL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JHHHONJIKGL)
			{
				return null;
			}
			return (FOFBDBJBEJE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JHHHONJIKGL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			if (!HasName)
			{
				return "";
			}
			return (string)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = ProtoPreconditions.CheckNotNull(value, "value");
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.Name;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasName => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.Name;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBOKDHDOKAD HMIHLDPMPOM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
			{
				return null;
			}
			return (OBOKDHDOKAD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HMIHLDPMPOM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyRelicFilterPlanScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyRelicFilterPlanScRsp(ModifyRelicFilterPlanScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		eKLKHPGDPOL_ = other.eKLKHPGDPOL_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.JHHHONJIKGL:
			JHHHONJIKGL = other.JHHHONJIKGL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.Name:
			Name = other.Name;
			break;
		case BPIHFAJCLOCOneofCase.HMIHLDPMPOM:
			HMIHLDPMPOM = other.HMIHLDPMPOM.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyRelicFilterPlanScRsp Clone()
	{
		return new ModifyRelicFilterPlanScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearName()
	{
		if (HasName)
		{
			ClearBPIHFAJCLOC();
		}
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
		return Equals(other as ModifyRelicFilterPlanScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ModifyRelicFilterPlanScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
		{
			return false;
		}
		if (EKLKHPGDPOL != other.EKLKHPGDPOL)
		{
			return false;
		}
		if (!object.Equals(JHHHONJIKGL, other.JHHHONJIKGL))
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!object.Equals(HMIHLDPMPOM, other.HMIHLDPMPOM))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
		}
		if (EKLKHPGDPOL != 0L)
		{
			num ^= EKLKHPGDPOL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JHHHONJIKGL)
		{
			num ^= JHHHONJIKGL.GetHashCode();
		}
		if (HasName)
		{
			num ^= Name.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
		{
			num ^= HMIHLDPMPOM.GetHashCode();
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JHHHONJIKGL)
		{
			output.WriteRawTag(10);
			output.WriteMessage(JHHHONJIKGL);
		}
		if (HasName)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(KKGIEENCOIC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
		{
			output.WriteRawTag(82);
			output.WriteMessage(HMIHLDPMPOM);
		}
		if (EKLKHPGDPOL != 0L)
		{
			output.WriteRawTag(112);
			output.WriteInt64(EKLKHPGDPOL);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (EKLKHPGDPOL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EKLKHPGDPOL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JHHHONJIKGL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHHHONJIKGL);
		}
		if (HasName)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMIHLDPMPOM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ModifyRelicFilterPlanScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.KKGIEENCOIC != 0)
		{
			KKGIEENCOIC = other.KKGIEENCOIC;
		}
		if (other.EKLKHPGDPOL != 0L)
		{
			EKLKHPGDPOL = other.EKLKHPGDPOL;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.JHHHONJIKGL:
			if (JHHHONJIKGL == null)
			{
				JHHHONJIKGL = new FOFBDBJBEJE();
			}
			JHHHONJIKGL.MergeFrom(other.JHHHONJIKGL);
			break;
		case BPIHFAJCLOCOneofCase.Name:
			Name = other.Name;
			break;
		case BPIHFAJCLOCOneofCase.HMIHLDPMPOM:
			if (HMIHLDPMPOM == null)
			{
				HMIHLDPMPOM = new OBOKDHDOKAD();
			}
			HMIHLDPMPOM.MergeFrom(other.HMIHLDPMPOM);
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
				FOFBDBJBEJE fOFBDBJBEJE = new FOFBDBJBEJE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JHHHONJIKGL)
				{
					fOFBDBJBEJE.MergeFrom(JHHHONJIKGL);
				}
				input.ReadMessage(fOFBDBJBEJE);
				JHHHONJIKGL = fOFBDBJBEJE;
				break;
			}
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 82u:
			{
				OBOKDHDOKAD oBOKDHDOKAD = new OBOKDHDOKAD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
				{
					oBOKDHDOKAD.MergeFrom(HMIHLDPMPOM);
				}
				input.ReadMessage(oBOKDHDOKAD);
				HMIHLDPMPOM = oBOKDHDOKAD;
				break;
			}
			case 112u:
				EKLKHPGDPOL = input.ReadInt64();
				break;
			}
		}
	}
}
