using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class INDJDBNFNIM : IMessage<INDJDBNFNIM>, IMessage, IEquatable<INDJDBNFNIM>, IDeepCloneable<INDJDBNFNIM>, IBufferMessage
{
	private static readonly MessageParser<INDJDBNFNIM> _parser = new MessageParser<INDJDBNFNIM>(() => new INDJDBNFNIM());

	private UnknownFieldSet _unknownFields;

	public const int LLIAJHMEJKIFieldNumber = 14;

	private LGOPLIAFLCK lLIAJHMEJKI_;

	public const int BDBILIBBHMPFieldNumber = 15;

	private LGOPLIAFLCK bDBILIBBHMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<INDJDBNFNIM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => INDJDBNFNIMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGOPLIAFLCK LLIAJHMEJKI
	{
		get
		{
			return lLIAJHMEJKI_;
		}
		set
		{
			lLIAJHMEJKI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGOPLIAFLCK BDBILIBBHMP
	{
		get
		{
			return bDBILIBBHMP_;
		}
		set
		{
			bDBILIBBHMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INDJDBNFNIM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INDJDBNFNIM(INDJDBNFNIM other)
		: this()
	{
		lLIAJHMEJKI_ = ((other.lLIAJHMEJKI_ != null) ? other.lLIAJHMEJKI_.Clone() : null);
		bDBILIBBHMP_ = ((other.bDBILIBBHMP_ != null) ? other.bDBILIBBHMP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INDJDBNFNIM Clone()
	{
		return new INDJDBNFNIM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as INDJDBNFNIM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(INDJDBNFNIM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LLIAJHMEJKI, other.LLIAJHMEJKI))
		{
			return false;
		}
		if (!object.Equals(BDBILIBBHMP, other.BDBILIBBHMP))
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
		if (lLIAJHMEJKI_ != null)
		{
			num ^= LLIAJHMEJKI.GetHashCode();
		}
		if (bDBILIBBHMP_ != null)
		{
			num ^= BDBILIBBHMP.GetHashCode();
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
		if (lLIAJHMEJKI_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(LLIAJHMEJKI);
		}
		if (bDBILIBBHMP_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(BDBILIBBHMP);
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
		if (lLIAJHMEJKI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LLIAJHMEJKI);
		}
		if (bDBILIBBHMP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BDBILIBBHMP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(INDJDBNFNIM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lLIAJHMEJKI_ != null)
		{
			if (lLIAJHMEJKI_ == null)
			{
				LLIAJHMEJKI = new LGOPLIAFLCK();
			}
			LLIAJHMEJKI.MergeFrom(other.LLIAJHMEJKI);
		}
		if (other.bDBILIBBHMP_ != null)
		{
			if (bDBILIBBHMP_ == null)
			{
				BDBILIBBHMP = new LGOPLIAFLCK();
			}
			BDBILIBBHMP.MergeFrom(other.BDBILIBBHMP);
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
			case 114u:
				if (lLIAJHMEJKI_ == null)
				{
					LLIAJHMEJKI = new LGOPLIAFLCK();
				}
				input.ReadMessage(LLIAJHMEJKI);
				break;
			case 122u:
				if (bDBILIBBHMP_ == null)
				{
					BDBILIBBHMP = new LGOPLIAFLCK();
				}
				input.ReadMessage(BDBILIBBHMP);
				break;
			}
		}
	}
}
