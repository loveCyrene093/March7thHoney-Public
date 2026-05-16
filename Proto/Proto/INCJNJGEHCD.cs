using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class INCJNJGEHCD : IMessage<INCJNJGEHCD>, IMessage, IEquatable<INCJNJGEHCD>, IDeepCloneable<INCJNJGEHCD>, IBufferMessage
{
	private static readonly MessageParser<INCJNJGEHCD> _parser = new MessageParser<INCJNJGEHCD>(() => new INCJNJGEHCD());

	private UnknownFieldSet _unknownFields;

	public const int FFEACPDFAJHFieldNumber = 2;

	private string fFEACPDFAJH_ = "";

	public const int CEOFDMCJAPJFieldNumber = 8;

	private uint cEOFDMCJAPJ_;

	public const int GBMBMFFNKEHFieldNumber = 14;

	private uint gBMBMFFNKEH_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<INCJNJGEHCD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => INCJNJGEHCDReflection.Descriptor.MessageTypes[0];

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
	public INCJNJGEHCD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INCJNJGEHCD(INCJNJGEHCD other)
		: this()
	{
		fFEACPDFAJH_ = other.fFEACPDFAJH_;
		cEOFDMCJAPJ_ = other.cEOFDMCJAPJ_;
		gBMBMFFNKEH_ = other.gBMBMFFNKEH_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INCJNJGEHCD Clone()
	{
		return new INCJNJGEHCD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as INCJNJGEHCD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(INCJNJGEHCD other)
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
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
			output.WriteRawTag(18);
			output.WriteString(FFEACPDFAJH);
		}
		if (CEOFDMCJAPJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CEOFDMCJAPJ);
		}
		if (GBMBMFFNKEH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GBMBMFFNKEH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(INCJNJGEHCD other)
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
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 18u:
				FFEACPDFAJH = input.ReadString();
				break;
			case 64u:
				CEOFDMCJAPJ = input.ReadUInt32();
				break;
			case 112u:
				GBMBMFFNKEH = input.ReadUInt32();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
