using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddRelicFilterPlanCsReq : IMessage<AddRelicFilterPlanCsReq>, IMessage, IEquatable<AddRelicFilterPlanCsReq>, IDeepCloneable<AddRelicFilterPlanCsReq>, IBufferMessage
{
	private static readonly MessageParser<AddRelicFilterPlanCsReq> _parser = new MessageParser<AddRelicFilterPlanCsReq>(() => new AddRelicFilterPlanCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IsMarkedFieldNumber = 4;

	private bool isMarked_;

	public const int NameFieldNumber = 5;

	private string name_ = "";

	public const int HMIHLDPMPOMFieldNumber = 6;

	private OBOKDHDOKAD hMIHLDPMPOM_;

	public const int JHHHONJIKGLFieldNumber = 8;

	private FOFBDBJBEJE jHHHONJIKGL_;

	public const int BHPLKHAMBIGFieldNumber = 9;

	private uint bHPLKHAMBIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AddRelicFilterPlanCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AddRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public AddRelicFilterPlanCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddRelicFilterPlanCsReq(AddRelicFilterPlanCsReq other)
		: this()
	{
		isMarked_ = other.isMarked_;
		name_ = other.name_;
		hMIHLDPMPOM_ = ((other.hMIHLDPMPOM_ != null) ? other.hMIHLDPMPOM_.Clone() : null);
		jHHHONJIKGL_ = ((other.jHHHONJIKGL_ != null) ? other.jHHHONJIKGL_.Clone() : null);
		bHPLKHAMBIG_ = other.bHPLKHAMBIG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddRelicFilterPlanCsReq Clone()
	{
		return new AddRelicFilterPlanCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AddRelicFilterPlanCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AddRelicFilterPlanCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsMarked != other.IsMarked)
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
		if (!object.Equals(JHHHONJIKGL, other.JHHHONJIKGL))
		{
			return false;
		}
		if (BHPLKHAMBIG != other.BHPLKHAMBIG)
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
		if (IsMarked)
		{
			num ^= IsMarked.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (hMIHLDPMPOM_ != null)
		{
			num ^= HMIHLDPMPOM.GetHashCode();
		}
		if (jHHHONJIKGL_ != null)
		{
			num ^= JHHHONJIKGL.GetHashCode();
		}
		if (BHPLKHAMBIG != 0)
		{
			num ^= BHPLKHAMBIG.GetHashCode();
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
		if (IsMarked)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsMarked);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Name);
		}
		if (hMIHLDPMPOM_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(HMIHLDPMPOM);
		}
		if (jHHHONJIKGL_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(JHHHONJIKGL);
		}
		if (BHPLKHAMBIG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BHPLKHAMBIG);
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
		if (IsMarked)
		{
			num += 2;
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (hMIHLDPMPOM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMIHLDPMPOM);
		}
		if (jHHHONJIKGL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHHHONJIKGL);
		}
		if (BHPLKHAMBIG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHPLKHAMBIG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AddRelicFilterPlanCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IsMarked)
		{
			IsMarked = other.IsMarked;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.hMIHLDPMPOM_ != null)
		{
			if (hMIHLDPMPOM_ == null)
			{
				HMIHLDPMPOM = new OBOKDHDOKAD();
			}
			HMIHLDPMPOM.MergeFrom(other.HMIHLDPMPOM);
		}
		if (other.jHHHONJIKGL_ != null)
		{
			if (jHHHONJIKGL_ == null)
			{
				JHHHONJIKGL = new FOFBDBJBEJE();
			}
			JHHHONJIKGL.MergeFrom(other.JHHHONJIKGL);
		}
		if (other.BHPLKHAMBIG != 0)
		{
			BHPLKHAMBIG = other.BHPLKHAMBIG;
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
			case 32u:
				IsMarked = input.ReadBool();
				break;
			case 42u:
				Name = input.ReadString();
				break;
			case 50u:
				if (hMIHLDPMPOM_ == null)
				{
					HMIHLDPMPOM = new OBOKDHDOKAD();
				}
				input.ReadMessage(HMIHLDPMPOM);
				break;
			case 66u:
				if (jHHHONJIKGL_ == null)
				{
					JHHHONJIKGL = new FOFBDBJBEJE();
				}
				input.ReadMessage(JHHHONJIKGL);
				break;
			case 72u:
				BHPLKHAMBIG = input.ReadUInt32();
				break;
			}
		}
	}
}
