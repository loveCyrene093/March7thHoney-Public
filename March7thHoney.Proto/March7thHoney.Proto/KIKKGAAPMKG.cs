using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KIKKGAAPMKG : IMessage<KIKKGAAPMKG>, IMessage, IEquatable<KIKKGAAPMKG>, IDeepCloneable<KIKKGAAPMKG>, IBufferMessage
{
	private static readonly MessageParser<KIKKGAAPMKG> _parser = new MessageParser<KIKKGAAPMKG>(() => new KIKKGAAPMKG());

	private UnknownFieldSet _unknownFields;

	public const int NGEHILEENKCFieldNumber = 4;

	private uint nGEHILEENKC_;

	public const int PPPHLHADCPJFieldNumber = 15;

	private HMJGADLIONA pPPHLHADCPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KIKKGAAPMKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KIKKGAAPMKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGEHILEENKC
	{
		get
		{
			return nGEHILEENKC_;
		}
		set
		{
			nGEHILEENKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJGADLIONA PPPHLHADCPJ
	{
		get
		{
			return pPPHLHADCPJ_;
		}
		set
		{
			pPPHLHADCPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIKKGAAPMKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIKKGAAPMKG(KIKKGAAPMKG other)
		: this()
	{
		nGEHILEENKC_ = other.nGEHILEENKC_;
		pPPHLHADCPJ_ = ((other.pPPHLHADCPJ_ != null) ? other.pPPHLHADCPJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIKKGAAPMKG Clone()
	{
		return new KIKKGAAPMKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KIKKGAAPMKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KIKKGAAPMKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NGEHILEENKC != other.NGEHILEENKC)
		{
			return false;
		}
		if (!object.Equals(PPPHLHADCPJ, other.PPPHLHADCPJ))
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
		if (NGEHILEENKC != 0)
		{
			num ^= NGEHILEENKC.GetHashCode();
		}
		if (pPPHLHADCPJ_ != null)
		{
			num ^= PPPHLHADCPJ.GetHashCode();
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
		if (NGEHILEENKC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NGEHILEENKC);
		}
		if (pPPHLHADCPJ_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(PPPHLHADCPJ);
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
		if (NGEHILEENKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGEHILEENKC);
		}
		if (pPPHLHADCPJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPPHLHADCPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KIKKGAAPMKG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NGEHILEENKC != 0)
		{
			NGEHILEENKC = other.NGEHILEENKC;
		}
		if (other.pPPHLHADCPJ_ != null)
		{
			if (pPPHLHADCPJ_ == null)
			{
				PPPHLHADCPJ = new HMJGADLIONA();
			}
			PPPHLHADCPJ.MergeFrom(other.PPPHLHADCPJ);
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
				NGEHILEENKC = input.ReadUInt32();
				break;
			case 122u:
				if (pPPHLHADCPJ_ == null)
				{
					PPPHLHADCPJ = new HMJGADLIONA();
				}
				input.ReadMessage(PPPHLHADCPJ);
				break;
			}
		}
	}
}
