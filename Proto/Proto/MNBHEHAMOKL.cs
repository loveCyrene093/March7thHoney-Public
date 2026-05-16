using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MNBHEHAMOKL : IMessage<MNBHEHAMOKL>, IMessage, IEquatable<MNBHEHAMOKL>, IDeepCloneable<MNBHEHAMOKL>, IBufferMessage
{
	private static readonly MessageParser<MNBHEHAMOKL> _parser = new MessageParser<MNBHEHAMOKL>(() => new MNBHEHAMOKL());

	private UnknownFieldSet _unknownFields;

	public const int CHCNEDNCIDJFieldNumber = 2;

	private bool cHCNEDNCIDJ_;

	public const int CPOGDKALGOMFieldNumber = 3;

	private bool cPOGDKALGOM_;

	public const int FIJNAPNICJFFieldNumber = 6;

	private bool fIJNAPNICJF_;

	public const int NHLKFBOBDOMFieldNumber = 13;

	private bool nHLKFBOBDOM_;

	public const int LPEPIDNJDEMFieldNumber = 14;

	private bool lPEPIDNJDEM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MNBHEHAMOKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MNBHEHAMOKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CHCNEDNCIDJ
	{
		get
		{
			return cHCNEDNCIDJ_;
		}
		set
		{
			cHCNEDNCIDJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CPOGDKALGOM
	{
		get
		{
			return cPOGDKALGOM_;
		}
		set
		{
			cPOGDKALGOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FIJNAPNICJF
	{
		get
		{
			return fIJNAPNICJF_;
		}
		set
		{
			fIJNAPNICJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NHLKFBOBDOM
	{
		get
		{
			return nHLKFBOBDOM_;
		}
		set
		{
			nHLKFBOBDOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LPEPIDNJDEM
	{
		get
		{
			return lPEPIDNJDEM_;
		}
		set
		{
			lPEPIDNJDEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNBHEHAMOKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNBHEHAMOKL(MNBHEHAMOKL other)
		: this()
	{
		cHCNEDNCIDJ_ = other.cHCNEDNCIDJ_;
		cPOGDKALGOM_ = other.cPOGDKALGOM_;
		fIJNAPNICJF_ = other.fIJNAPNICJF_;
		nHLKFBOBDOM_ = other.nHLKFBOBDOM_;
		lPEPIDNJDEM_ = other.lPEPIDNJDEM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNBHEHAMOKL Clone()
	{
		return new MNBHEHAMOKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MNBHEHAMOKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MNBHEHAMOKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CHCNEDNCIDJ != other.CHCNEDNCIDJ)
		{
			return false;
		}
		if (CPOGDKALGOM != other.CPOGDKALGOM)
		{
			return false;
		}
		if (FIJNAPNICJF != other.FIJNAPNICJF)
		{
			return false;
		}
		if (NHLKFBOBDOM != other.NHLKFBOBDOM)
		{
			return false;
		}
		if (LPEPIDNJDEM != other.LPEPIDNJDEM)
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
		if (CHCNEDNCIDJ)
		{
			num ^= CHCNEDNCIDJ.GetHashCode();
		}
		if (CPOGDKALGOM)
		{
			num ^= CPOGDKALGOM.GetHashCode();
		}
		if (FIJNAPNICJF)
		{
			num ^= FIJNAPNICJF.GetHashCode();
		}
		if (NHLKFBOBDOM)
		{
			num ^= NHLKFBOBDOM.GetHashCode();
		}
		if (LPEPIDNJDEM)
		{
			num ^= LPEPIDNJDEM.GetHashCode();
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
		if (CHCNEDNCIDJ)
		{
			output.WriteRawTag(16);
			output.WriteBool(CHCNEDNCIDJ);
		}
		if (CPOGDKALGOM)
		{
			output.WriteRawTag(24);
			output.WriteBool(CPOGDKALGOM);
		}
		if (FIJNAPNICJF)
		{
			output.WriteRawTag(48);
			output.WriteBool(FIJNAPNICJF);
		}
		if (NHLKFBOBDOM)
		{
			output.WriteRawTag(104);
			output.WriteBool(NHLKFBOBDOM);
		}
		if (LPEPIDNJDEM)
		{
			output.WriteRawTag(112);
			output.WriteBool(LPEPIDNJDEM);
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
		if (CHCNEDNCIDJ)
		{
			num += 2;
		}
		if (CPOGDKALGOM)
		{
			num += 2;
		}
		if (FIJNAPNICJF)
		{
			num += 2;
		}
		if (NHLKFBOBDOM)
		{
			num += 2;
		}
		if (LPEPIDNJDEM)
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
	public void MergeFrom(MNBHEHAMOKL other)
	{
		if (other != null)
		{
			if (other.CHCNEDNCIDJ)
			{
				CHCNEDNCIDJ = other.CHCNEDNCIDJ;
			}
			if (other.CPOGDKALGOM)
			{
				CPOGDKALGOM = other.CPOGDKALGOM;
			}
			if (other.FIJNAPNICJF)
			{
				FIJNAPNICJF = other.FIJNAPNICJF;
			}
			if (other.NHLKFBOBDOM)
			{
				NHLKFBOBDOM = other.NHLKFBOBDOM;
			}
			if (other.LPEPIDNJDEM)
			{
				LPEPIDNJDEM = other.LPEPIDNJDEM;
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
			case 16u:
				CHCNEDNCIDJ = input.ReadBool();
				break;
			case 24u:
				CPOGDKALGOM = input.ReadBool();
				break;
			case 48u:
				FIJNAPNICJF = input.ReadBool();
				break;
			case 104u:
				NHLKFBOBDOM = input.ReadBool();
				break;
			case 112u:
				LPEPIDNJDEM = input.ReadBool();
				break;
			}
		}
	}
}
