using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DNJFGOLLCCB : IMessage<DNJFGOLLCCB>, IMessage, IEquatable<DNJFGOLLCCB>, IDeepCloneable<DNJFGOLLCCB>, IBufferMessage
{
	private static readonly MessageParser<DNJFGOLLCCB> _parser = new MessageParser<DNJFGOLLCCB>(() => new DNJFGOLLCCB());

	private UnknownFieldSet _unknownFields;

	public const int LGMNKILABNLFieldNumber = 1;

	private string lGMNKILABNL_ = "";

	public const int CJBODNKDFAGFieldNumber = 2;

	private string cJBODNKDFAG_ = "";

	public const int AJLGJKMEFJLFieldNumber = 3;

	private string aJLGJKMEFJL_ = "";

	public const int GNCPFFHBIPNFieldNumber = 4;

	private string gNCPFFHBIPN_ = "";

	public const int COOFHIGHJDNFieldNumber = 5;

	private string cOOFHIGHJDN_ = "";

	public const int NMBNLPOHJCMFieldNumber = 6;

	private string nMBNLPOHJCM_ = "";

	public const int CDNBELIAJFNFieldNumber = 7;

	private string cDNBELIAJFN_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DNJFGOLLCCB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DNJFGOLLCCBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LGMNKILABNL
	{
		get
		{
			return lGMNKILABNL_;
		}
		set
		{
			lGMNKILABNL_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CJBODNKDFAG
	{
		get
		{
			return cJBODNKDFAG_;
		}
		set
		{
			cJBODNKDFAG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AJLGJKMEFJL
	{
		get
		{
			return aJLGJKMEFJL_;
		}
		set
		{
			aJLGJKMEFJL_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GNCPFFHBIPN
	{
		get
		{
			return gNCPFFHBIPN_;
		}
		set
		{
			gNCPFFHBIPN_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string COOFHIGHJDN
	{
		get
		{
			return cOOFHIGHJDN_;
		}
		set
		{
			cOOFHIGHJDN_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string NMBNLPOHJCM
	{
		get
		{
			return nMBNLPOHJCM_;
		}
		set
		{
			nMBNLPOHJCM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CDNBELIAJFN
	{
		get
		{
			return cDNBELIAJFN_;
		}
		set
		{
			cDNBELIAJFN_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNJFGOLLCCB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNJFGOLLCCB(DNJFGOLLCCB other)
		: this()
	{
		lGMNKILABNL_ = other.lGMNKILABNL_;
		cJBODNKDFAG_ = other.cJBODNKDFAG_;
		aJLGJKMEFJL_ = other.aJLGJKMEFJL_;
		gNCPFFHBIPN_ = other.gNCPFFHBIPN_;
		cOOFHIGHJDN_ = other.cOOFHIGHJDN_;
		nMBNLPOHJCM_ = other.nMBNLPOHJCM_;
		cDNBELIAJFN_ = other.cDNBELIAJFN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNJFGOLLCCB Clone()
	{
		return new DNJFGOLLCCB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DNJFGOLLCCB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DNJFGOLLCCB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LGMNKILABNL != other.LGMNKILABNL)
		{
			return false;
		}
		if (CJBODNKDFAG != other.CJBODNKDFAG)
		{
			return false;
		}
		if (AJLGJKMEFJL != other.AJLGJKMEFJL)
		{
			return false;
		}
		if (GNCPFFHBIPN != other.GNCPFFHBIPN)
		{
			return false;
		}
		if (COOFHIGHJDN != other.COOFHIGHJDN)
		{
			return false;
		}
		if (NMBNLPOHJCM != other.NMBNLPOHJCM)
		{
			return false;
		}
		if (CDNBELIAJFN != other.CDNBELIAJFN)
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
		if (LGMNKILABNL.Length != 0)
		{
			num ^= LGMNKILABNL.GetHashCode();
		}
		if (CJBODNKDFAG.Length != 0)
		{
			num ^= CJBODNKDFAG.GetHashCode();
		}
		if (AJLGJKMEFJL.Length != 0)
		{
			num ^= AJLGJKMEFJL.GetHashCode();
		}
		if (GNCPFFHBIPN.Length != 0)
		{
			num ^= GNCPFFHBIPN.GetHashCode();
		}
		if (COOFHIGHJDN.Length != 0)
		{
			num ^= COOFHIGHJDN.GetHashCode();
		}
		if (NMBNLPOHJCM.Length != 0)
		{
			num ^= NMBNLPOHJCM.GetHashCode();
		}
		if (CDNBELIAJFN.Length != 0)
		{
			num ^= CDNBELIAJFN.GetHashCode();
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
		if (LGMNKILABNL.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(LGMNKILABNL);
		}
		if (CJBODNKDFAG.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(CJBODNKDFAG);
		}
		if (AJLGJKMEFJL.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AJLGJKMEFJL);
		}
		if (GNCPFFHBIPN.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(GNCPFFHBIPN);
		}
		if (COOFHIGHJDN.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(COOFHIGHJDN);
		}
		if (NMBNLPOHJCM.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(NMBNLPOHJCM);
		}
		if (CDNBELIAJFN.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(CDNBELIAJFN);
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
		if (LGMNKILABNL.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LGMNKILABNL);
		}
		if (CJBODNKDFAG.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CJBODNKDFAG);
		}
		if (AJLGJKMEFJL.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AJLGJKMEFJL);
		}
		if (GNCPFFHBIPN.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GNCPFFHBIPN);
		}
		if (COOFHIGHJDN.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(COOFHIGHJDN);
		}
		if (NMBNLPOHJCM.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NMBNLPOHJCM);
		}
		if (CDNBELIAJFN.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CDNBELIAJFN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DNJFGOLLCCB other)
	{
		if (other != null)
		{
			if (other.LGMNKILABNL.Length != 0)
			{
				LGMNKILABNL = other.LGMNKILABNL;
			}
			if (other.CJBODNKDFAG.Length != 0)
			{
				CJBODNKDFAG = other.CJBODNKDFAG;
			}
			if (other.AJLGJKMEFJL.Length != 0)
			{
				AJLGJKMEFJL = other.AJLGJKMEFJL;
			}
			if (other.GNCPFFHBIPN.Length != 0)
			{
				GNCPFFHBIPN = other.GNCPFFHBIPN;
			}
			if (other.COOFHIGHJDN.Length != 0)
			{
				COOFHIGHJDN = other.COOFHIGHJDN;
			}
			if (other.NMBNLPOHJCM.Length != 0)
			{
				NMBNLPOHJCM = other.NMBNLPOHJCM;
			}
			if (other.CDNBELIAJFN.Length != 0)
			{
				CDNBELIAJFN = other.CDNBELIAJFN;
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
			case 10u:
				LGMNKILABNL = input.ReadString();
				break;
			case 18u:
				CJBODNKDFAG = input.ReadString();
				break;
			case 26u:
				AJLGJKMEFJL = input.ReadString();
				break;
			case 34u:
				GNCPFFHBIPN = input.ReadString();
				break;
			case 42u:
				COOFHIGHJDN = input.ReadString();
				break;
			case 50u:
				NMBNLPOHJCM = input.ReadString();
				break;
			case 58u:
				CDNBELIAJFN = input.ReadString();
				break;
			}
		}
	}
}
