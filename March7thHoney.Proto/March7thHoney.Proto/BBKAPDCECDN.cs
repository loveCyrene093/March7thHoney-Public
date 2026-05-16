using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBKAPDCECDN : IMessage<BBKAPDCECDN>, IMessage, IEquatable<BBKAPDCECDN>, IDeepCloneable<BBKAPDCECDN>, IBufferMessage
{
	private static readonly MessageParser<BBKAPDCECDN> _parser = new MessageParser<BBKAPDCECDN>(() => new BBKAPDCECDN());

	private UnknownFieldSet _unknownFields;

	public const int MMAOONPAPDPFieldNumber = 5;

	private CAEABHJNLMI mMAOONPAPDP_;

	public const int CJOPDNAIEMKFieldNumber = 13;

	private uint cJOPDNAIEMK_;

	public const int PBLCNBMMBKCFieldNumber = 14;

	private uint pBLCNBMMBKC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBKAPDCECDN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBKAPDCECDNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAEABHJNLMI MMAOONPAPDP
	{
		get
		{
			return mMAOONPAPDP_;
		}
		set
		{
			mMAOONPAPDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJOPDNAIEMK
	{
		get
		{
			return cJOPDNAIEMK_;
		}
		set
		{
			cJOPDNAIEMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PBLCNBMMBKC
	{
		get
		{
			return pBLCNBMMBKC_;
		}
		set
		{
			pBLCNBMMBKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBKAPDCECDN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBKAPDCECDN(BBKAPDCECDN other)
		: this()
	{
		mMAOONPAPDP_ = ((other.mMAOONPAPDP_ != null) ? other.mMAOONPAPDP_.Clone() : null);
		cJOPDNAIEMK_ = other.cJOPDNAIEMK_;
		pBLCNBMMBKC_ = other.pBLCNBMMBKC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBKAPDCECDN Clone()
	{
		return new BBKAPDCECDN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBKAPDCECDN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBKAPDCECDN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MMAOONPAPDP, other.MMAOONPAPDP))
		{
			return false;
		}
		if (CJOPDNAIEMK != other.CJOPDNAIEMK)
		{
			return false;
		}
		if (PBLCNBMMBKC != other.PBLCNBMMBKC)
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
		if (mMAOONPAPDP_ != null)
		{
			num ^= MMAOONPAPDP.GetHashCode();
		}
		if (CJOPDNAIEMK != 0)
		{
			num ^= CJOPDNAIEMK.GetHashCode();
		}
		if (PBLCNBMMBKC != 0)
		{
			num ^= PBLCNBMMBKC.GetHashCode();
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
		if (mMAOONPAPDP_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MMAOONPAPDP);
		}
		if (CJOPDNAIEMK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CJOPDNAIEMK);
		}
		if (PBLCNBMMBKC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PBLCNBMMBKC);
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
		if (mMAOONPAPDP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MMAOONPAPDP);
		}
		if (CJOPDNAIEMK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJOPDNAIEMK);
		}
		if (PBLCNBMMBKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBLCNBMMBKC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBKAPDCECDN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mMAOONPAPDP_ != null)
		{
			if (mMAOONPAPDP_ == null)
			{
				MMAOONPAPDP = new CAEABHJNLMI();
			}
			MMAOONPAPDP.MergeFrom(other.MMAOONPAPDP);
		}
		if (other.CJOPDNAIEMK != 0)
		{
			CJOPDNAIEMK = other.CJOPDNAIEMK;
		}
		if (other.PBLCNBMMBKC != 0)
		{
			PBLCNBMMBKC = other.PBLCNBMMBKC;
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
			case 42u:
				if (mMAOONPAPDP_ == null)
				{
					MMAOONPAPDP = new CAEABHJNLMI();
				}
				input.ReadMessage(MMAOONPAPDP);
				break;
			case 104u:
				CJOPDNAIEMK = input.ReadUInt32();
				break;
			case 112u:
				PBLCNBMMBKC = input.ReadUInt32();
				break;
			}
		}
	}
}
