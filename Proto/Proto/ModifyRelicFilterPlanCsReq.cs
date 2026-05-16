using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ModifyRelicFilterPlanCsReq : IMessage<ModifyRelicFilterPlanCsReq>, IMessage, IEquatable<ModifyRelicFilterPlanCsReq>, IDeepCloneable<ModifyRelicFilterPlanCsReq>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		HMIHLDPMPOM = 1,
		JHHHONJIKGL = 14,
		Name = 15
	}

	private static readonly MessageParser<ModifyRelicFilterPlanCsReq> _parser = new MessageParser<ModifyRelicFilterPlanCsReq>(() => new ModifyRelicFilterPlanCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KKGIEENCOICFieldNumber = 6;

	private uint kKGIEENCOIC_;

	public const int HMIHLDPMPOMFieldNumber = 1;

	public const int JHHHONJIKGLFieldNumber = 14;

	public const int NameFieldNumber = 15;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ModifyRelicFilterPlanCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ModifyRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyRelicFilterPlanCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyRelicFilterPlanCsReq(ModifyRelicFilterPlanCsReq other)
		: this()
	{
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.HMIHLDPMPOM:
			HMIHLDPMPOM = other.HMIHLDPMPOM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JHHHONJIKGL:
			JHHHONJIKGL = other.JHHHONJIKGL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.Name:
			Name = other.Name;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyRelicFilterPlanCsReq Clone()
	{
		return new ModifyRelicFilterPlanCsReq(this);
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
		return Equals(other as ModifyRelicFilterPlanCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ModifyRelicFilterPlanCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
		{
			return false;
		}
		if (!object.Equals(HMIHLDPMPOM, other.HMIHLDPMPOM))
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
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
		{
			num ^= HMIHLDPMPOM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JHHHONJIKGL)
		{
			num ^= JHHHONJIKGL.GetHashCode();
		}
		if (HasName)
		{
			num ^= Name.GetHashCode();
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HMIHLDPMPOM);
		}
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KKGIEENCOIC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JHHHONJIKGL)
		{
			output.WriteRawTag(114);
			output.WriteMessage(JHHHONJIKGL);
		}
		if (HasName)
		{
			output.WriteRawTag(122);
			output.WriteString(Name);
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
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMIHLDPMPOM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JHHHONJIKGL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHHHONJIKGL);
		}
		if (HasName)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ModifyRelicFilterPlanCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KKGIEENCOIC != 0)
		{
			KKGIEENCOIC = other.KKGIEENCOIC;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.HMIHLDPMPOM:
			if (HMIHLDPMPOM == null)
			{
				HMIHLDPMPOM = new OBOKDHDOKAD();
			}
			HMIHLDPMPOM.MergeFrom(other.HMIHLDPMPOM);
			break;
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
				OBOKDHDOKAD oBOKDHDOKAD = new OBOKDHDOKAD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMIHLDPMPOM)
				{
					oBOKDHDOKAD.MergeFrom(HMIHLDPMPOM);
				}
				input.ReadMessage(oBOKDHDOKAD);
				HMIHLDPMPOM = oBOKDHDOKAD;
				break;
			}
			case 48u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 114u:
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
			case 122u:
				Name = input.ReadString();
				break;
			}
		}
	}
}
