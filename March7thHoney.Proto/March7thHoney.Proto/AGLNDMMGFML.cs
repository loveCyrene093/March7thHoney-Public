using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AGLNDMMGFML : IMessage<AGLNDMMGFML>, IMessage, IEquatable<AGLNDMMGFML>, IDeepCloneable<AGLNDMMGFML>, IBufferMessage
{
	private static readonly MessageParser<AGLNDMMGFML> _parser = new MessageParser<AGLNDMMGFML>(() => new AGLNDMMGFML());

	private UnknownFieldSet _unknownFields;

	public const int DIHECIIKELEFieldNumber = 6;

	private JIPACDEJKJC dIHECIIKELE_;

	public const int FHPMEPJNBBFFieldNumber = 14;

	private IMMMNLEAIBH fHPMEPJNBBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AGLNDMMGFML> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AGLNDMMGFMLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIPACDEJKJC DIHECIIKELE
	{
		get
		{
			return dIHECIIKELE_;
		}
		set
		{
			dIHECIIKELE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMMMNLEAIBH FHPMEPJNBBF
	{
		get
		{
			return fHPMEPJNBBF_;
		}
		set
		{
			fHPMEPJNBBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGLNDMMGFML()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGLNDMMGFML(AGLNDMMGFML other)
		: this()
	{
		dIHECIIKELE_ = ((other.dIHECIIKELE_ != null) ? other.dIHECIIKELE_.Clone() : null);
		fHPMEPJNBBF_ = other.fHPMEPJNBBF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGLNDMMGFML Clone()
	{
		return new AGLNDMMGFML(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AGLNDMMGFML);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AGLNDMMGFML other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DIHECIIKELE, other.DIHECIIKELE))
		{
			return false;
		}
		if (FHPMEPJNBBF != other.FHPMEPJNBBF)
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
		if (dIHECIIKELE_ != null)
		{
			num ^= DIHECIIKELE.GetHashCode();
		}
		if (FHPMEPJNBBF != IMMMNLEAIBH.Pcpdhelpkem)
		{
			num ^= FHPMEPJNBBF.GetHashCode();
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
		if (dIHECIIKELE_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(DIHECIIKELE);
		}
		if (FHPMEPJNBBF != IMMMNLEAIBH.Pcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)FHPMEPJNBBF);
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
		if (dIHECIIKELE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DIHECIIKELE);
		}
		if (FHPMEPJNBBF != IMMMNLEAIBH.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FHPMEPJNBBF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AGLNDMMGFML other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dIHECIIKELE_ != null)
		{
			if (dIHECIIKELE_ == null)
			{
				DIHECIIKELE = new JIPACDEJKJC();
			}
			DIHECIIKELE.MergeFrom(other.DIHECIIKELE);
		}
		if (other.FHPMEPJNBBF != IMMMNLEAIBH.Pcpdhelpkem)
		{
			FHPMEPJNBBF = other.FHPMEPJNBBF;
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
			case 50u:
				if (dIHECIIKELE_ == null)
				{
					DIHECIIKELE = new JIPACDEJKJC();
				}
				input.ReadMessage(DIHECIIKELE);
				break;
			case 112u:
				FHPMEPJNBBF = (IMMMNLEAIBH)input.ReadEnum();
				break;
			}
		}
	}
}
