using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BIELAAMEPDK : IMessage<BIELAAMEPDK>, IMessage, IEquatable<BIELAAMEPDK>, IDeepCloneable<BIELAAMEPDK>, IBufferMessage
{
	private static readonly MessageParser<BIELAAMEPDK> _parser = new MessageParser<BIELAAMEPDK>(() => new BIELAAMEPDK());

	private UnknownFieldSet _unknownFields;

	public const int HAOPEKPKOFIFieldNumber = 3;

	private bool hAOPEKPKOFI_;

	public const int NLKNEENFHAMFieldNumber = 9;

	private ILLBNKFBNBP nLKNEENFHAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BIELAAMEPDK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BIELAAMEPDKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HAOPEKPKOFI
	{
		get
		{
			return hAOPEKPKOFI_;
		}
		set
		{
			hAOPEKPKOFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILLBNKFBNBP NLKNEENFHAM
	{
		get
		{
			return nLKNEENFHAM_;
		}
		set
		{
			nLKNEENFHAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIELAAMEPDK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIELAAMEPDK(BIELAAMEPDK other)
		: this()
	{
		hAOPEKPKOFI_ = other.hAOPEKPKOFI_;
		nLKNEENFHAM_ = ((other.nLKNEENFHAM_ != null) ? other.nLKNEENFHAM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIELAAMEPDK Clone()
	{
		return new BIELAAMEPDK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BIELAAMEPDK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BIELAAMEPDK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HAOPEKPKOFI != other.HAOPEKPKOFI)
		{
			return false;
		}
		if (!object.Equals(NLKNEENFHAM, other.NLKNEENFHAM))
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
		if (HAOPEKPKOFI)
		{
			num ^= HAOPEKPKOFI.GetHashCode();
		}
		if (nLKNEENFHAM_ != null)
		{
			num ^= NLKNEENFHAM.GetHashCode();
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
		if (HAOPEKPKOFI)
		{
			output.WriteRawTag(24);
			output.WriteBool(HAOPEKPKOFI);
		}
		if (nLKNEENFHAM_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(NLKNEENFHAM);
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
		if (HAOPEKPKOFI)
		{
			num += 2;
		}
		if (nLKNEENFHAM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NLKNEENFHAM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BIELAAMEPDK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HAOPEKPKOFI)
		{
			HAOPEKPKOFI = other.HAOPEKPKOFI;
		}
		if (other.nLKNEENFHAM_ != null)
		{
			if (nLKNEENFHAM_ == null)
			{
				NLKNEENFHAM = new ILLBNKFBNBP();
			}
			NLKNEENFHAM.MergeFrom(other.NLKNEENFHAM);
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
			case 24u:
				HAOPEKPKOFI = input.ReadBool();
				break;
			case 74u:
				if (nLKNEENFHAM_ == null)
				{
					NLKNEENFHAM = new ILLBNKFBNBP();
				}
				input.ReadMessage(NLKNEENFHAM);
				break;
			}
		}
	}
}
