using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MEBBEGGFJMI : IMessage<MEBBEGGFJMI>, IMessage, IEquatable<MEBBEGGFJMI>, IDeepCloneable<MEBBEGGFJMI>, IBufferMessage
{
	private static readonly MessageParser<MEBBEGGFJMI> _parser = new MessageParser<MEBBEGGFJMI>(() => new MEBBEGGFJMI());

	private UnknownFieldSet _unknownFields;

	public const int TitleFieldNumber = 1;

	private string title_ = "";

	public const int NLGKMNLEDGDFieldNumber = 2;

	private string nLGKMNLEDGD_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MEBBEGGFJMI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MEBBEGGFJMIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string NLGKMNLEDGD
	{
		get
		{
			return nLGKMNLEDGD_;
		}
		set
		{
			nLGKMNLEDGD_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEBBEGGFJMI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEBBEGGFJMI(MEBBEGGFJMI other)
		: this()
	{
		title_ = other.title_;
		nLGKMNLEDGD_ = other.nLGKMNLEDGD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEBBEGGFJMI Clone()
	{
		return new MEBBEGGFJMI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MEBBEGGFJMI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MEBBEGGFJMI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Title != other.Title)
		{
			return false;
		}
		if (NLGKMNLEDGD != other.NLGKMNLEDGD)
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
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (NLGKMNLEDGD.Length != 0)
		{
			num ^= NLGKMNLEDGD.GetHashCode();
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
		if (Title.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Title);
		}
		if (NLGKMNLEDGD.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(NLGKMNLEDGD);
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
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (NLGKMNLEDGD.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NLGKMNLEDGD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MEBBEGGFJMI other)
	{
		if (other != null)
		{
			if (other.Title.Length != 0)
			{
				Title = other.Title;
			}
			if (other.NLGKMNLEDGD.Length != 0)
			{
				NLGKMNLEDGD = other.NLGKMNLEDGD;
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
				Title = input.ReadString();
				break;
			case 18u:
				NLGKMNLEDGD = input.ReadString();
				break;
			}
		}
	}
}
