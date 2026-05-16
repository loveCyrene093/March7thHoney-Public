using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AJNICOHFJGC : IMessage<AJNICOHFJGC>, IMessage, IEquatable<AJNICOHFJGC>, IDeepCloneable<AJNICOHFJGC>, IBufferMessage
{
	private static readonly MessageParser<AJNICOHFJGC> _parser = new MessageParser<AJNICOHFJGC>(() => new AJNICOHFJGC());

	private UnknownFieldSet _unknownFields;

	public const int IJIMFPEKPOKFieldNumber = 2;

	private uint iJIMFPEKPOK_;

	public const int IMKOJKJAHMMFieldNumber = 5;

	private KBNIJFEMBPJ iMKOJKJAHMM_;

	public const int IHMKJGKOPKCFieldNumber = 10;

	private bool iHMKJGKOPKC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AJNICOHFJGC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AJNICOHFJGCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJIMFPEKPOK
	{
		get
		{
			return iJIMFPEKPOK_;
		}
		set
		{
			iJIMFPEKPOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBNIJFEMBPJ IMKOJKJAHMM
	{
		get
		{
			return iMKOJKJAHMM_;
		}
		set
		{
			iMKOJKJAHMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IHMKJGKOPKC
	{
		get
		{
			return iHMKJGKOPKC_;
		}
		set
		{
			iHMKJGKOPKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJNICOHFJGC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJNICOHFJGC(AJNICOHFJGC other)
		: this()
	{
		iJIMFPEKPOK_ = other.iJIMFPEKPOK_;
		iMKOJKJAHMM_ = ((other.iMKOJKJAHMM_ != null) ? other.iMKOJKJAHMM_.Clone() : null);
		iHMKJGKOPKC_ = other.iHMKJGKOPKC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJNICOHFJGC Clone()
	{
		return new AJNICOHFJGC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AJNICOHFJGC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AJNICOHFJGC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IJIMFPEKPOK != other.IJIMFPEKPOK)
		{
			return false;
		}
		if (!object.Equals(IMKOJKJAHMM, other.IMKOJKJAHMM))
		{
			return false;
		}
		if (IHMKJGKOPKC != other.IHMKJGKOPKC)
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
		if (IJIMFPEKPOK != 0)
		{
			num ^= IJIMFPEKPOK.GetHashCode();
		}
		if (iMKOJKJAHMM_ != null)
		{
			num ^= IMKOJKJAHMM.GetHashCode();
		}
		if (IHMKJGKOPKC)
		{
			num ^= IHMKJGKOPKC.GetHashCode();
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
		if (IJIMFPEKPOK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IJIMFPEKPOK);
		}
		if (iMKOJKJAHMM_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(IMKOJKJAHMM);
		}
		if (IHMKJGKOPKC)
		{
			output.WriteRawTag(80);
			output.WriteBool(IHMKJGKOPKC);
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
		if (IJIMFPEKPOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJIMFPEKPOK);
		}
		if (iMKOJKJAHMM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMKOJKJAHMM);
		}
		if (IHMKJGKOPKC)
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
	public void MergeFrom(AJNICOHFJGC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IJIMFPEKPOK != 0)
		{
			IJIMFPEKPOK = other.IJIMFPEKPOK;
		}
		if (other.iMKOJKJAHMM_ != null)
		{
			if (iMKOJKJAHMM_ == null)
			{
				IMKOJKJAHMM = new KBNIJFEMBPJ();
			}
			IMKOJKJAHMM.MergeFrom(other.IMKOJKJAHMM);
		}
		if (other.IHMKJGKOPKC)
		{
			IHMKJGKOPKC = other.IHMKJGKOPKC;
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
			case 16u:
				IJIMFPEKPOK = input.ReadUInt32();
				break;
			case 42u:
				if (iMKOJKJAHMM_ == null)
				{
					IMKOJKJAHMM = new KBNIJFEMBPJ();
				}
				input.ReadMessage(IMKOJKJAHMM);
				break;
			case 80u:
				IHMKJGKOPKC = input.ReadBool();
				break;
			}
		}
	}
}
