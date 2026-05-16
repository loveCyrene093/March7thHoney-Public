using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BNLIEIGJKIA : IMessage<BNLIEIGJKIA>, IMessage, IEquatable<BNLIEIGJKIA>, IDeepCloneable<BNLIEIGJKIA>, IBufferMessage
{
	private static readonly MessageParser<BNLIEIGJKIA> _parser = new MessageParser<BNLIEIGJKIA>(() => new BNLIEIGJKIA());

	private UnknownFieldSet _unknownFields;

	public const int FFEACPDFAJHFieldNumber = 4;

	private string fFEACPDFAJH_ = "";

	public const int CEOFDMCJAPJFieldNumber = 6;

	private uint cEOFDMCJAPJ_;

	public const int GBMBMFFNKEHFieldNumber = 9;

	private uint gBMBMFFNKEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BNLIEIGJKIA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BNLIEIGJKIAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FFEACPDFAJH
	{
		get
		{
			return fFEACPDFAJH_;
		}
		set
		{
			fFEACPDFAJH_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEOFDMCJAPJ
	{
		get
		{
			return cEOFDMCJAPJ_;
		}
		set
		{
			cEOFDMCJAPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GBMBMFFNKEH
	{
		get
		{
			return gBMBMFFNKEH_;
		}
		set
		{
			gBMBMFFNKEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNLIEIGJKIA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNLIEIGJKIA(BNLIEIGJKIA other)
		: this()
	{
		fFEACPDFAJH_ = other.fFEACPDFAJH_;
		cEOFDMCJAPJ_ = other.cEOFDMCJAPJ_;
		gBMBMFFNKEH_ = other.gBMBMFFNKEH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNLIEIGJKIA Clone()
	{
		return new BNLIEIGJKIA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BNLIEIGJKIA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BNLIEIGJKIA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FFEACPDFAJH != other.FFEACPDFAJH)
		{
			return false;
		}
		if (CEOFDMCJAPJ != other.CEOFDMCJAPJ)
		{
			return false;
		}
		if (GBMBMFFNKEH != other.GBMBMFFNKEH)
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
		if (FFEACPDFAJH.Length != 0)
		{
			num ^= FFEACPDFAJH.GetHashCode();
		}
		if (CEOFDMCJAPJ != 0)
		{
			num ^= CEOFDMCJAPJ.GetHashCode();
		}
		if (GBMBMFFNKEH != 0)
		{
			num ^= GBMBMFFNKEH.GetHashCode();
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
		if (FFEACPDFAJH.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(FFEACPDFAJH);
		}
		if (CEOFDMCJAPJ != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CEOFDMCJAPJ);
		}
		if (GBMBMFFNKEH != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GBMBMFFNKEH);
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
		if (FFEACPDFAJH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FFEACPDFAJH);
		}
		if (CEOFDMCJAPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEOFDMCJAPJ);
		}
		if (GBMBMFFNKEH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GBMBMFFNKEH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BNLIEIGJKIA other)
	{
		if (other != null)
		{
			if (other.FFEACPDFAJH.Length != 0)
			{
				FFEACPDFAJH = other.FFEACPDFAJH;
			}
			if (other.CEOFDMCJAPJ != 0)
			{
				CEOFDMCJAPJ = other.CEOFDMCJAPJ;
			}
			if (other.GBMBMFFNKEH != 0)
			{
				GBMBMFFNKEH = other.GBMBMFFNKEH;
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
			case 34u:
				FFEACPDFAJH = input.ReadString();
				break;
			case 48u:
				CEOFDMCJAPJ = input.ReadUInt32();
				break;
			case 72u:
				GBMBMFFNKEH = input.ReadUInt32();
				break;
			}
		}
	}
}
