using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KHCHPPLOFJN : IMessage<KHCHPPLOFJN>, IMessage, IEquatable<KHCHPPLOFJN>, IDeepCloneable<KHCHPPLOFJN>, IBufferMessage
{
	public enum EPIIJJCAKIEOneofCase
	{
		None = 0,
		ANLBKEJPHFK = 12,
		PIHGDHAKLCB = 13,
		MNCFNIEHMKK = 15
	}

	private static readonly MessageParser<KHCHPPLOFJN> _parser = new MessageParser<KHCHPPLOFJN>(() => new KHCHPPLOFJN());

	private UnknownFieldSet _unknownFields;

	public const int KHDLMPAKEGFFieldNumber = 8;

	private uint kHDLMPAKEGF_;

	public const int ConfigIdFieldNumber = 9;

	private uint configId_;

	public const int GCPNCEDAMABFieldNumber = 14;

	private uint gCPNCEDAMAB_;

	public const int ANLBKEJPHFKFieldNumber = 12;

	public const int PIHGDHAKLCBFieldNumber = 13;

	public const int MNCFNIEHMKKFieldNumber = 15;

	private object ePIIJJCAKIE_;

	private EPIIJJCAKIEOneofCase ePIIJJCAKIECase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KHCHPPLOFJN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KHCHPPLOFJNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHDLMPAKEGF
	{
		get
		{
			return kHDLMPAKEGF_;
		}
		set
		{
			kHDLMPAKEGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCPNCEDAMAB
	{
		get
		{
			return gCPNCEDAMAB_;
		}
		set
		{
			gCPNCEDAMAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMDMPGHIINI ANLBKEJPHFK
	{
		get
		{
			if (ePIIJJCAKIECase_ != EPIIJJCAKIEOneofCase.ANLBKEJPHFK)
			{
				return null;
			}
			return (NMDMPGHIINI)ePIIJJCAKIE_;
		}
		set
		{
			ePIIJJCAKIE_ = value;
			ePIIJJCAKIECase_ = ((value != null) ? EPIIJJCAKIEOneofCase.ANLBKEJPHFK : EPIIJJCAKIEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJBMLDMLANE PIHGDHAKLCB
	{
		get
		{
			if (ePIIJJCAKIECase_ != EPIIJJCAKIEOneofCase.PIHGDHAKLCB)
			{
				return null;
			}
			return (HJBMLDMLANE)ePIIJJCAKIE_;
		}
		set
		{
			ePIIJJCAKIE_ = value;
			ePIIJJCAKIECase_ = ((value != null) ? EPIIJJCAKIEOneofCase.PIHGDHAKLCB : EPIIJJCAKIEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCADEHNDGLF MNCFNIEHMKK
	{
		get
		{
			if (ePIIJJCAKIECase_ != EPIIJJCAKIEOneofCase.MNCFNIEHMKK)
			{
				return null;
			}
			return (JCADEHNDGLF)ePIIJJCAKIE_;
		}
		set
		{
			ePIIJJCAKIE_ = value;
			ePIIJJCAKIECase_ = ((value != null) ? EPIIJJCAKIEOneofCase.MNCFNIEHMKK : EPIIJJCAKIEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPIIJJCAKIEOneofCase EPIIJJCAKIECase => ePIIJJCAKIECase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCHPPLOFJN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCHPPLOFJN(KHCHPPLOFJN other)
		: this()
	{
		kHDLMPAKEGF_ = other.kHDLMPAKEGF_;
		configId_ = other.configId_;
		gCPNCEDAMAB_ = other.gCPNCEDAMAB_;
		switch (other.EPIIJJCAKIECase)
		{
		case EPIIJJCAKIEOneofCase.ANLBKEJPHFK:
			ANLBKEJPHFK = other.ANLBKEJPHFK.Clone();
			break;
		case EPIIJJCAKIEOneofCase.PIHGDHAKLCB:
			PIHGDHAKLCB = other.PIHGDHAKLCB.Clone();
			break;
		case EPIIJJCAKIEOneofCase.MNCFNIEHMKK:
			MNCFNIEHMKK = other.MNCFNIEHMKK.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCHPPLOFJN Clone()
	{
		return new KHCHPPLOFJN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEPIIJJCAKIE()
	{
		ePIIJJCAKIECase_ = EPIIJJCAKIEOneofCase.None;
		ePIIJJCAKIE_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KHCHPPLOFJN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KHCHPPLOFJN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KHDLMPAKEGF != other.KHDLMPAKEGF)
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (GCPNCEDAMAB != other.GCPNCEDAMAB)
		{
			return false;
		}
		if (!object.Equals(ANLBKEJPHFK, other.ANLBKEJPHFK))
		{
			return false;
		}
		if (!object.Equals(PIHGDHAKLCB, other.PIHGDHAKLCB))
		{
			return false;
		}
		if (!object.Equals(MNCFNIEHMKK, other.MNCFNIEHMKK))
		{
			return false;
		}
		if (EPIIJJCAKIECase != other.EPIIJJCAKIECase)
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
		if (KHDLMPAKEGF != 0)
		{
			num ^= KHDLMPAKEGF.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (GCPNCEDAMAB != 0)
		{
			num ^= GCPNCEDAMAB.GetHashCode();
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.ANLBKEJPHFK)
		{
			num ^= ANLBKEJPHFK.GetHashCode();
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.PIHGDHAKLCB)
		{
			num ^= PIHGDHAKLCB.GetHashCode();
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.MNCFNIEHMKK)
		{
			num ^= MNCFNIEHMKK.GetHashCode();
		}
		num ^= (int)ePIIJJCAKIECase_;
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
		if (KHDLMPAKEGF != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(KHDLMPAKEGF);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ConfigId);
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.ANLBKEJPHFK)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ANLBKEJPHFK);
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.PIHGDHAKLCB)
		{
			output.WriteRawTag(106);
			output.WriteMessage(PIHGDHAKLCB);
		}
		if (GCPNCEDAMAB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GCPNCEDAMAB);
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.MNCFNIEHMKK)
		{
			output.WriteRawTag(122);
			output.WriteMessage(MNCFNIEHMKK);
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
		if (KHDLMPAKEGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHDLMPAKEGF);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (GCPNCEDAMAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCPNCEDAMAB);
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.ANLBKEJPHFK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ANLBKEJPHFK);
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.PIHGDHAKLCB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PIHGDHAKLCB);
		}
		if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.MNCFNIEHMKK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNCFNIEHMKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KHCHPPLOFJN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KHDLMPAKEGF != 0)
		{
			KHDLMPAKEGF = other.KHDLMPAKEGF;
		}
		if (other.ConfigId != 0)
		{
			ConfigId = other.ConfigId;
		}
		if (other.GCPNCEDAMAB != 0)
		{
			GCPNCEDAMAB = other.GCPNCEDAMAB;
		}
		switch (other.EPIIJJCAKIECase)
		{
		case EPIIJJCAKIEOneofCase.ANLBKEJPHFK:
			if (ANLBKEJPHFK == null)
			{
				ANLBKEJPHFK = new NMDMPGHIINI();
			}
			ANLBKEJPHFK.MergeFrom(other.ANLBKEJPHFK);
			break;
		case EPIIJJCAKIEOneofCase.PIHGDHAKLCB:
			if (PIHGDHAKLCB == null)
			{
				PIHGDHAKLCB = new HJBMLDMLANE();
			}
			PIHGDHAKLCB.MergeFrom(other.PIHGDHAKLCB);
			break;
		case EPIIJJCAKIEOneofCase.MNCFNIEHMKK:
			if (MNCFNIEHMKK == null)
			{
				MNCFNIEHMKK = new JCADEHNDGLF();
			}
			MNCFNIEHMKK.MergeFrom(other.MNCFNIEHMKK);
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
			case 64u:
				KHDLMPAKEGF = input.ReadUInt32();
				break;
			case 72u:
				ConfigId = input.ReadUInt32();
				break;
			case 98u:
			{
				NMDMPGHIINI nMDMPGHIINI = new NMDMPGHIINI();
				if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.ANLBKEJPHFK)
				{
					nMDMPGHIINI.MergeFrom(ANLBKEJPHFK);
				}
				input.ReadMessage(nMDMPGHIINI);
				ANLBKEJPHFK = nMDMPGHIINI;
				break;
			}
			case 106u:
			{
				HJBMLDMLANE hJBMLDMLANE = new HJBMLDMLANE();
				if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.PIHGDHAKLCB)
				{
					hJBMLDMLANE.MergeFrom(PIHGDHAKLCB);
				}
				input.ReadMessage(hJBMLDMLANE);
				PIHGDHAKLCB = hJBMLDMLANE;
				break;
			}
			case 112u:
				GCPNCEDAMAB = input.ReadUInt32();
				break;
			case 122u:
			{
				JCADEHNDGLF jCADEHNDGLF = new JCADEHNDGLF();
				if (ePIIJJCAKIECase_ == EPIIJJCAKIEOneofCase.MNCFNIEHMKK)
				{
					jCADEHNDGLF.MergeFrom(MNCFNIEHMKK);
				}
				input.ReadMessage(jCADEHNDGLF);
				MNCFNIEHMKK = jCADEHNDGLF;
				break;
			}
			}
		}
	}
}
